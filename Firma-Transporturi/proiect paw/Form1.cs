using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_paw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateTransporturi();
        }

        public void UpdateTransporturi()
        {
            listViewTransporturi.Items.Clear();
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.transporturi;";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem lvi = new ListViewItem(dataReader.GetInt32(0).ToString());
                lvi.SubItems.Add(dataReader.GetString(1).ToString());
                lvi.SubItems.Add(dataReader.GetString(2).ToString());
                lvi.SubItems.Add(dataReader.GetString(3).ToString());
                lvi.SubItems.Add(dataReader.GetString(4).ToString());
                lvi.SubItems.Add(dataReader.GetString(6).ToString());
                lvi.SubItems.Add(dataReader.GetString(10).ToString());
                lvi.SubItems.Add(dataReader.GetString(11).ToString());
                lvi.SubItems.Add(dataReader.GetString(12).ToString());
                listViewTransporturi.Items.Add(lvi);
            }
            conexiune.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmatransporturiDataSet.soferi' table. You can move, or remove it, as needed.
            this.soferiTableAdapter.Fill(this.firmatransporturiDataSet.soferi);

        }

        private void soferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoferi formSoferi = new FormSoferi(this);
            formSoferi.Show();
            //this.Hide();
        }

        private void masiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasini formMasini = new FormMasini(this);
            formMasini.Show();
            //this.Hide();
        }

        private void buttonAdaugaTransport_Click(object sender, EventArgs e)
        {
            FormAdaugaTransport adauga = new FormAdaugaTransport(this);
            adauga.Show();
        }

        private void listViewTransporturi_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(listViewTransporturi.SelectedItems[0].Text, DragDropEffects.Copy);
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            string id;
            id = (string)e.Data.GetData(DataFormats.Text);
            string queryStergere = "delete from dbo.transporturi where id= " + id + ";";
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            SqlCommand command = new SqlCommand(queryStergere, conexiune);
            command.ExecuteNonQuery();
            conexiune.Close();
            UpdateTransporturi();
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic grafic = new FormGrafic(this);
            grafic.Show();
        }

        private void buttonAfisareMasini_Click(object sender, EventArgs e)
        {
            List<Masina> masini = new List<Masina>();
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.masini";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Masina masina = new Masina();
                masina.nrInmatriculare = dataReader["nrInmatriculare"].ToString();
                masina.capacitate = dataReader["capacitate"].ToString();
                masina.categorie = dataReader["categorie"].ToString();
                masini.Add(masina);
            }
            conexiune.Close();
            string fileName = "Masini.txt";

            try
            {

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }



                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (Masina m in masini)
                    {
                        sw.WriteLine("Masina cu numarul: " + m.nrInmatriculare + " are capacitatea " + m.capacitate + " si se conduce cu categoria " + m.categorie);
                    }
                }

 
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
