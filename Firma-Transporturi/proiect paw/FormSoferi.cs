using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_paw
{
    public partial class FormSoferi : Form
    {
        Form1 parinte;

        public FormSoferi(Form1 parinte)
        {
            InitializeComponent();
            this.parinte = parinte;
            UpdateSoferi();
        }

        public void UpdateSoferi()
        {
            listViewSoferi.Items.Clear();
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.soferi";
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
                listViewSoferi.Items.Add(lvi);
            }
            conexiune.Close();
        }

        private void buttonAdaugaSofer_Click(object sender, EventArgs e)
        {
            FormAdaugaSofer formAdauga = new FormAdaugaSofer(this);
            formAdauga.Show();
        }

        private void listViewSoferi_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listViewSoferi.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idDeSters = listViewSoferi.SelectedItems[0].Text;
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string delete_sql = "delete from dbo.soferi where id = '"+idDeSters+"';";
            SqlCommand command = new SqlCommand(delete_sql, conexiune);
            command.ExecuteNonQuery();
            UpdateSoferi();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaSoferi formModif = new FormModificaSoferi(this);
            formModif.Show();
            formModif.textBoxNume.Text = this.listViewSoferi.SelectedItems[0].SubItems[1].Text;
            formModif.textBoxPrenume.Text = this.listViewSoferi.SelectedItems[0].SubItems[2].Text;
            formModif.textBoxCNP.Text = this.listViewSoferi.SelectedItems[0].SubItems[3].Text;
            formModif.userControlCategoriePermis1.comboBoxCategorie.SelectedItem = this.listViewSoferi.SelectedItems[0].SubItems[4].Text;
        }
    }
}
