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
    public partial class FormMasini : Form
    {
        Form1 parinte;
        public FormMasini(Form1 parinte)
        {
            InitializeComponent();
            this.parinte = parinte;
            UpdateMasini();
        }
        public void UpdateMasini()
        {
            listViewMasini.Items.Clear();
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.masini";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem lvi = new ListViewItem(dataReader.GetInt32(0).ToString());
                lvi.SubItems.Add(dataReader.GetString(1).ToString());
                lvi.SubItems.Add(dataReader.GetString(2).ToString());
                lvi.SubItems.Add(dataReader.GetString(3).ToString());
                listViewMasini.Items.Add(lvi);
            }
            conexiune.Close();
        }

        private void buttonMeniuAdaugaMasini_Click(object sender, EventArgs e)
        {
            FormAdaugaMasini formAdaugaMasini = new FormAdaugaMasini(this);
            formAdaugaMasini.Show();
        }

        private void listViewMasini_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listViewMasini.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStripMasini.Show(Cursor.Position);
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idDeSters = listViewMasini.SelectedItems[0].Text;
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string delete_sql = "delete from dbo.masini where id = '" + idDeSters + "';";
            SqlCommand command = new SqlCommand(delete_sql, conexiune);
            command.ExecuteNonQuery();
            UpdateMasini();
        }
    }
}
