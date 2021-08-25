using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_paw
{
    public partial class FormGrafic : Form
    {
        Form1 parinte;
        public int[] lista;
        int nrElem;
        public FormGrafic(Form1 parinte)
        {
            InitializeComponent();
            lista = new int[4];
            nrElem = 4;
            for (int i = 0; i < 4; i++)
                lista[i] = 0;
            this.parinte = parinte;
            SqlConnection conexiune = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;Initial Catalog = firmatransporturi;Integrated security=true");
            conexiune.Open();
            string select_sql = "select * from dbo.soferi";
            SqlCommand command = new SqlCommand(select_sql, conexiune);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string categorie = dataReader["cat_permis"].ToString();
                if (categorie == "B")
                    lista[0]++;
                else
                    if (categorie == "C")
                    lista[1]++;
                else
                    if (categorie == "D")
                    lista[2]++;
                else
                    if (categorie == "E")
                    lista[3]++;
            }
            conexiune.Close();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            const int marg = 30;
            Font font = new Font("Times New Roman", 12.0f);
            Graphics g = e.Graphics;

            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 2 * marg,
                panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, rec);

            double latime = rec.Width / this.nrElem / 3;
            double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
            double vMax = lista.Max();

            Brush br = new SolidBrush(Color.DarkSlateGray);

            Rectangle[] recs = new Rectangle[nrElem];
            string[] tipuri = { "B", "C", "D", "E" };
            for (int i = 0; i < nrElem; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                  (int)(rec.Location.Y + rec.Height - lista[i] / vMax * rec.Height),
                  (int)latime,
                  (int)(lista[i] / vMax * rec.Height));
                g.DrawString(tipuri[i], font, br, new Point((int)(recs[i].Location.X),
                    (int)(recs[i].Location.Y - font.Height * 2)));
                g.DrawString(lista[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                    (int)(recs[i].Location.Y - font.Height)));

            }
            g.FillRectangles(br, recs);
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            pd.DefaultPageSettings.Landscape = true;

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            const int marg = 30;
            Font font = new Font("Times New Roman", 12.0f);
            Graphics g = e.Graphics;

            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 2 * marg,
                panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, rec);

            double latime = rec.Width / this.nrElem / 3;
            double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
            double vMax = lista.Max();

            Brush br = new SolidBrush(Color.DarkSlateGray);

            Rectangle[] recs = new Rectangle[nrElem];
            string[] tipuri = { "B", "C", "D", "E" };
            for (int i = 0; i < nrElem; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                  (int)(rec.Location.Y + rec.Height - lista[i] / vMax * rec.Height),
                  (int)latime,
                  (int)(lista[i] / vMax * rec.Height));
                g.DrawString(tipuri[i], font, br, new Point((int)(recs[i].Location.X),
                    (int)(recs[i].Location.Y - font.Height * 2)));
                g.DrawString(lista[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                    (int)(recs[i].Location.Y - font.Height)));

            }
            g.FillRectangles(br, recs);
        }
    }
}
