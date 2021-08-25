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
    public partial class FormAdaugaTransport : Form
    {
        Form1 parinte;
        public FormAdaugaTransport(Form1 parinte)
        {
            InitializeComponent();
            this.parinte = parinte;
            //adaugare data in combobox masini
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select nrInmatriculare from dbo.masini";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string nrInmatriculare = dataReader.GetString(0);
                comboBox1.Items.Add(nrInmatriculare);
            }
            dataReader.Close();
            //adaugare data in combobox soferi
            string select_sql2 = "select nume from dbo.soferi";
            SqlCommand command2 = new SqlCommand(select_sql2, conexiune);
            SqlDataReader dataReader2;
            dataReader2 = command2.ExecuteReader();

            while (dataReader2.Read())
            {
                string nume = dataReader2.GetString(0);
                comboBox2.Items.Add(nume);
            }
            conexiune.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Am dat din greseala");
        }

        private void buttonAdaugaTransport_Click(object sender, EventArgs e)
        {

            Transport transport = new Transport();
            Masina masina = new Masina();
            Sofer sofer = new Sofer();

            transport.orasPlecare = textBoxOrasIncepere.Text;
            transport.orasSosire = textBoxOrasSosire.Text;
            transport.distanta = Int32.Parse(textBoxDist.Text);
            transport.cantitate = Int32.Parse(textBoxCantitate.Text);
            masina.nrInmatriculare = comboBox1.Text;
            sofer.nume = comboBox2.Text;

            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.masini where nrInmatriculare = '"+ masina.nrInmatriculare +"';";
            string select_sql2 = "select * from dbo.soferi where nume = '"+ sofer.nume +"';";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlCommand command2 = new SqlCommand(select_sql2, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
               masina.idMasina =  Int32.Parse(dataReader["id"].ToString());
                masina.categorie = dataReader["categorie"].ToString();
                masina.capacitate = dataReader["capacitate"].ToString();
            }
            dataReader.Close();
            dataReader = command2.ExecuteReader();
            while(dataReader.Read())
            {
                sofer.idSofer = Int32.Parse(dataReader["id"].ToString());
                sofer.prenume = dataReader["prenume"].ToString();
                sofer.cnp = dataReader["cnp"].ToString();
                sofer.catPermis = dataReader["cat_permis"].ToString();
            }
            dataReader.Close();
            transport.masina = masina;
            transport.sofer = sofer;
            string insert = "insert into dbo.transporturi (orasPlecare, orasSosire, distanta, cantitate, idMasina, nrInmatriculare, categorieMasina, capacitate, idSofer, nume, prenume, cnp, categorieSofer)" +
                "values ('" + transport.orasPlecare + "','" + transport.orasSosire + "','" + transport.distanta + "','" + transport.cantitate + "','" + transport.masina.idMasina + "'," +
                "'" + transport.masina.nrInmatriculare + "','" + transport.masina.categorie + "','" + transport.masina.capacitate + "'," +
                "'" + transport.sofer.idSofer + "','" + transport.sofer.nume + "','" + transport.sofer.prenume + "','" + transport.sofer.cnp + "','" + transport.sofer.catPermis + "');";
            SqlCommand command3 = new SqlCommand(insert, conexiune);
            command3.ExecuteNonQuery();
            parinte.UpdateTransporturi();
            conexiune.Close();
            this.Close();
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void textBoxOrasIncepere_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrasIncepere.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxOrasIncepere, "Orasul de incepere trebuie completat!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxOrasIncepere, "");
            }
        }

        private void textBoxOrasSosire_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrasSosire.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxOrasSosire, "Orasul de sosire trebuie completat!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxOrasSosire, "");
            }
        }

        private void textBoxDist_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDist.Text) || !IsDigitsOnly(textBoxDist.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxDist, "Distanta trebuie sa fie valida!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxDist, "");
            }
        }

        private void textBoxCantitate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCantitate.Text) || !IsDigitsOnly(textBoxCantitate.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxCantitate, "Cantitatea trebuie sa fie valida!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxCantitate, "");
            }
        }
    }
}
