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
    public partial class FrmNewCommande : Form
    {
        private int idClient;
        public FrmNewCommande()
        {
            InitializeComponent();
        }
        public FrmNewCommande(int idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
        }

        private void commandeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void FrmNewCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
            commandeBindingSource.AddNew();
            iD_clientTextBox.Text = idClient.ToString();
            date_commandeDateTimePicker.Value = DateTime.Now;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

            this.DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.commandeBindingSource.CancelEdit();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
