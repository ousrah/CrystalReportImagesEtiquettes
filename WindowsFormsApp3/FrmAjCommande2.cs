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
    public partial class FrmAjCommande2 : Form
    {
        private int idClient;
        public FrmAjCommande2()
        {
            InitializeComponent();
        }

        public FrmAjCommande2(int idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void commandeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void FrmAjCommande2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Commande);
            commandeBindingSource.AddNew();
            iD_clientTextBox.Text = this.idClient.ToString();
            date_commandeDateTimePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            commandeBindingSource.CancelEdit();
            this.Close();
        }
    }
}
