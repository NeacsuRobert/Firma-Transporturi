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
    public partial class FormAdaugaMasini : Form
    {
        FormMasini parinte;
        public FormAdaugaMasini(FormMasini parinte)
        {
            InitializeComponent();
            this.parinte = parinte;
        }

        private void buttonAdaugaMasina_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string insert_sql = "insert into dbo.masini(nrInmatriculare,capacitate,categorie) values('" + textBoxNrInmatriculare.Text + "','" + textBoxCapacitate.Text + "','"  + userControlCategoriePermis1.comboBoxCategorie.Text + "'); ";
            SqlCommand command = new SqlCommand(insert_sql, conexiune);
            command.ExecuteNonQuery();
            conexiune.Close();
            parinte.UpdateMasini();
            this.Close();
            parinte.Show();
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

        private void textBoxNrInmatriculare_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNrInmatriculare.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxNrInmatriculare, "Numarul de inmatriculare trebuie completat!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNrInmatriculare, "");
            }
        }

        private void textBoxCapacitate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCapacitate.Text) || !IsDigitsOnly(textBoxCapacitate.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxCapacitate, "Capacitatea trebuie sa fie valida!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxCapacitate, "");
            }
        }
    }
}
