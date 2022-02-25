using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmProduitsParCategorie : Form
    {
        public frmProduitsParCategorie()
        {
            InitializeComponent();
        }

        private void categorieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produitBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }
    }
}
