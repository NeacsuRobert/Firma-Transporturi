using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_paw
{
    public partial class UserControlCategoriePermis : UserControl
    {
        public UserControlCategoriePermis()
        {
            InitializeComponent();
            comboBoxCategorie.Items.Add("B");
            comboBoxCategorie.Items.Add("C");
            comboBoxCategorie.Items.Add("D");
            comboBoxCategorie.Items.Add("E");
        }
    }
}
