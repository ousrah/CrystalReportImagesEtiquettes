using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories f = new FrmCategories();
            f.ShowDialog();
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.ShowDialog();
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            FrmCommandes2 f = new FrmCommandes2();
            f.ShowDialog();
        }
    }
}
