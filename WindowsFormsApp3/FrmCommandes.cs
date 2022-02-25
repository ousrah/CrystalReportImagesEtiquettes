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
    public partial class FrmCommandes : Form
    {
        public FrmCommandes()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void FrmCommandes_Load(object sender, EventArgs e)
        {
             // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.TotalCommandes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.totalCommandesTableAdapter.Fill(this.gestionCommercialHamzaDataSet.TotalCommandes);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.ProduitsParCommande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsParCommandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.ProduitsParCommande);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.ShowDialog();
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);

        }

        private void btnAjoutCommande_Click(object sender, EventArgs e)
        {
            FrmNewCommande f = new FrmNewCommande(Convert.ToInt32(clientComboBox.SelectedValue));
            f.ShowDialog();
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            int idc = Convert.ToInt32(commandeDataGridView.CurrentRow.Cells[0].Value);
            string idp = produitComboBox.SelectedValue.ToString() ;
            double prix = Convert.ToDouble(prixUnitaireTextBox.Text);
            int qte = Convert.ToInt32(txtQte.Text);
            ligneTableAdapter.InsertLigne(idc, idp, qte, prix);

            this.totalCommandesTableAdapter.Fill(this.gestionCommercialHamzaDataSet.TotalCommandes);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.ProduitsParCommande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsParCommandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.ProduitsParCommande);


        }
    }
}
