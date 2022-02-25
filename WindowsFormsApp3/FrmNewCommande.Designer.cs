
namespace WindowsFormsApp3
{
    partial class FrmNewCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label date_commandeLabel;
            this.gestionCommercialHamzaDataSet = new WindowsFormsApp3.GestionCommercialHamzaDataSet();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.date_commandeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_clientTextBox = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            date_commandeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CommandeTableAdapter = this.commandeTableAdapter;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // date_commandeLabel
            // 
            date_commandeLabel.AutoSize = true;
            date_commandeLabel.Location = new System.Drawing.Point(30, 28);
            date_commandeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            date_commandeLabel.Name = "date_commandeLabel";
            date_commandeLabel.Size = new System.Drawing.Size(175, 25);
            date_commandeLabel.TabIndex = 3;
            date_commandeLabel.Text = "Date commande:";
            // 
            // date_commandeDateTimePicker
            // 
            this.date_commandeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.commandeBindingSource, "Date_commande", true));
            this.date_commandeDateTimePicker.Location = new System.Drawing.Point(35, 58);
            this.date_commandeDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.date_commandeDateTimePicker.Name = "date_commandeDateTimePicker";
            this.date_commandeDateTimePicker.Size = new System.Drawing.Size(403, 30);
            this.date_commandeDateTimePicker.TabIndex = 4;
            // 
            // iD_clientTextBox
            // 
            this.iD_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "ID_client", true));
            this.iD_clientTextBox.Location = new System.Drawing.Point(334, 269);
            this.iD_clientTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iD_clientTextBox.Name = "iD_clientTextBox";
            this.iD_clientTextBox.Size = new System.Drawing.Size(322, 30);
            this.iD_clientTextBox.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(63, 129);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 55);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(261, 129);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(125, 55);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmNewCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 221);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(date_commandeLabel);
            this.Controls.Add(this.date_commandeDateTimePicker);
            this.Controls.Add(this.iD_clientTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmNewCommande";
            this.Text = "FrmNewCommande";
            this.Load += new System.EventHandler(this.FrmNewCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker date_commandeDateTimePicker;
        private System.Windows.Forms.TextBox iD_clientTextBox;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}