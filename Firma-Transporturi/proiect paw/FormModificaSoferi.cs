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
    public partial class FormModificaSoferi : Form
    {
        FormSoferi parinte;
        public FormModificaSoferi(FormSoferi parinte)
        {
            this.parinte = parinte;
            InitializeComponent();
        }

        private void buttonModificaSofer_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string update_sql = "update dbo.soferi set nume='" + textBoxNume.Text + "',prenume='" + textBoxPrenume.Text + "',cnp='" + textBoxCNP.Text + "',cat_permis='" + userControlCategoriePermis1.comboBoxCategorie.Text + "'where id='"+parinte.listViewSoferi.SelectedItems[0].Text +"'; ";
            SqlCommand command = new SqlCommand(update_sql, conexiune);
            command.ExecuteNonQuery();
            conexiune.Close();
            parinte.Show();
            parinte.UpdateSoferi();
            this.Close();
        }
    }
}
