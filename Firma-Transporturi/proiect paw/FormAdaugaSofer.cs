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
    public partial class FormAdaugaSofer : Form
    {
        FormSoferi parinte;
        public FormAdaugaSofer(FormSoferi parinte)
        {
            this.parinte = parinte;
            InitializeComponent();
        }

        private void buttonAdaugaSoferPEBune_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
                conexiune.Open();
                string insert_sql = "insert into dbo.soferi(nume,prenume,cnp,cat_permis) values('" + textBoxNume.Text + "','" + textBoxPrenume.Text + "','" + textBoxCNP.Text + "','" + userControlCategoriePermis1.comboBoxCategorie.Text + "'); ";
                SqlCommand command = new SqlCommand(insert_sql, conexiune);
                command.ExecuteNonQuery();
                conexiune.Close();
                parinte.UpdateSoferi();
                this.Close();
                parinte.Show();
            }
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNume.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxNume, "Numele trebuie completat!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNume, "");
            }
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
        private void textBoxCNP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCNP.Text) || textBoxCNP.Text.Length != 13 || !IsDigitsOnly(textBoxCNP.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxCNP, "CNP-ul trebuie sa aiba 13 cifre!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxCNP, "");
            }
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrenume.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBoxPrenume, "Prenumele trebuie completat!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxPrenume, "");
            }
        }
    }
}
