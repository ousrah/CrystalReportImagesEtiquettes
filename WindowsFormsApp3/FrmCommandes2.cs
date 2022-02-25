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
    public partial class FrmCommandes2 : Form
    {
        public FrmCommandes2()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
        }

        private void FrmCommandes2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Total2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.total2TableAdapter.Fill(this.gestionCommercialHamzaDataSet.Total2);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.ProduitsParCommandes2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsParCommandes2TableAdapter.Fill(this.gestionCommercialHamzaDataSet.ProduitsParCommandes2);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.ShowDialog();
            this.clientTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAjCommande2 f = new FrmAjCommande2(Convert.ToInt32(clientComboBox.SelectedValue));
            f.ShowDialog();
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idc = Convert.ToInt32(commandeDataGridView.CurrentRow.Cells[0].Value);
            string idp = produitComboBox.SelectedValue.ToString();
            double prix = Convert.ToDouble(prixUnitaireTextBox.Text);
            int qte = Convert.ToInt32(txtQte.Text);
            produitsParCommandes2TableAdapter.InsertLigne(idc, idp, qte, prix);
            this.total2TableAdapter.Fill(this.gestionCommercialHamzaDataSet.Total2);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.ProduitsParCommandes2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsParCommandes2TableAdapter.Fill(this.gestionCommercialHamzaDataSet.ProduitsParCommandes2);

        }
    }
}
