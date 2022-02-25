
namespace WindowsFormsApp3
{
    partial class FrmCommandes
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
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.gestionCommercialHamzaDataSet = new WindowsFormsApp3.GestionCommercialHamzaDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.btnClients = new System.Windows.Forms.Button();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter();
            this.commandeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutCommande = new System.Windows.Forms.Button();
            this.produitsParCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitsParCommandeTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitsParCommandeTableAdapter();
            this.produitsParCommandeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCommandesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalCommandesTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TotalCommandesTableAdapter();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.produitComboBox = new System.Windows.Forms.ComboBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.ligneTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.LigneTableAdapter();
            totalLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCommandesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(1249, 374);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 24);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "total:";
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CommandeTableAdapter = null;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "Nom_client";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(31, 94);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(374, 30);
            this.clientComboBox.TabIndex = 1;
            this.clientComboBox.ValueMember = "ID_client";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(415, 94);
            this.btnClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(55, 32);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "...";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "FK_Commande_Client";
            this.commandeBindingSource.DataSource = this.clientBindingSource;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // commandeDataGridView
            // 
            this.commandeDataGridView.AllowUserToAddRows = false;
            this.commandeDataGridView.AllowUserToDeleteRows = false;
            this.commandeDataGridView.AutoGenerateColumns = false;
            this.commandeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.commandeDataGridView.DataSource = this.commandeBindingSource;
            this.commandeDataGridView.Location = new System.Drawing.Point(31, 133);
            this.commandeDataGridView.Name = "commandeDataGridView";
            this.commandeDataGridView.ReadOnly = true;
            this.commandeDataGridView.RowHeadersWidth = 51;
            this.commandeDataGridView.RowTemplate.Height = 24;
            this.commandeDataGridView.Size = new System.Drawing.Size(439, 220);
            this.commandeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_commande";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_commande";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // btnAjoutCommande
            // 
            this.btnAjoutCommande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjoutCommande.Location = new System.Drawing.Point(31, 369);
            this.btnAjoutCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjoutCommande.Name = "btnAjoutCommande";
            this.btnAjoutCommande.Size = new System.Drawing.Size(152, 29);
            this.btnAjoutCommande.TabIndex = 3;
            this.btnAjoutCommande.Text = "Ajouter";
            this.btnAjoutCommande.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjoutCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAjoutCommande.UseVisualStyleBackColor = true;
            this.btnAjoutCommande.Click += new System.EventHandler(this.btnAjoutCommande_Click);
            // 
            // produitsParCommandeBindingSource
            // 
            this.produitsParCommandeBindingSource.DataMember = "Commande_ProduitsParCommande";
            this.produitsParCommandeBindingSource.DataSource = this.commandeBindingSource;
            // 
            // produitsParCommandeTableAdapter
            // 
            this.produitsParCommandeTableAdapter.ClearBeforeFill = true;
            // 
            // produitsParCommandeDataGridView
            // 
            this.produitsParCommandeDataGridView.AllowUserToAddRows = false;
            this.produitsParCommandeDataGridView.AllowUserToDeleteRows = false;
            this.produitsParCommandeDataGridView.AutoGenerateColumns = false;
            this.produitsParCommandeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitsParCommandeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9});
            this.produitsParCommandeDataGridView.DataSource = this.produitsParCommandeBindingSource;
            this.produitsParCommandeDataGridView.Location = new System.Drawing.Point(504, 133);
            this.produitsParCommandeDataGridView.Name = "produitsParCommandeDataGridView";
            this.produitsParCommandeDataGridView.ReadOnly = true;
            this.produitsParCommandeDataGridView.RowHeadersWidth = 51;
            this.produitsParCommandeDataGridView.RowTemplate.Height = 24;
            this.produitsParCommandeDataGridView.Size = new System.Drawing.Size(970, 220);
            this.produitsParCommandeDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nom_cat";
            this.dataGridViewTextBoxColumn8.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_produit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Designation_produit";
            this.dataGridViewTextBoxColumn7.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qte";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qte";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // totalCommandesBindingSource
            // 
            this.totalCommandesBindingSource.DataMember = "FK_Ligne_Commande1";
            this.totalCommandesBindingSource.DataSource = this.commandeBindingSource;
            // 
            // totalCommandesTableAdapter
            // 
            this.totalCommandesTableAdapter.ClearBeforeFill = true;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalCommandesBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(1303, 373);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 28);
            this.totalTextBox.TabIndex = 8;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitComboBox
            // 
            this.produitComboBox.DataSource = this.produitBindingSource;
            this.produitComboBox.DisplayMember = "Designation_produit";
            this.produitComboBox.FormattingEnabled = true;
            this.produitComboBox.Location = new System.Drawing.Point(504, 94);
            this.produitComboBox.Name = "produitComboBox";
            this.produitComboBox.Size = new System.Drawing.Size(361, 30);
            this.produitComboBox.TabIndex = 8;
            this.produitComboBox.ValueMember = "ID_produit";
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(875, 61);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(114, 24);
            prixUnitaireLabel.TabIndex = 8;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(879, 96);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(213, 28);
            this.prixUnitaireTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(500, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 24);
            label1.TabIndex = 10;
            label1.Text = "Produits :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1110, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 24);
            label2.TabIndex = 11;
            label2.Text = "Quantité :";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(1114, 96);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(170, 28);
            this.txtQte.TabIndex = 12;
            this.txtQte.Text = "1";
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouterProduit.Location = new System.Drawing.Point(1322, 94);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(152, 29);
            this.btnAjouterProduit.TabIndex = 13;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjouterProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // ligneTableAdapter
            // 
            this.ligneTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 666);
            this.Controls.Add(this.btnAjouterProduit);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(prixUnitaireLabel);
            this.Controls.Add(this.prixUnitaireTextBox);
            this.Controls.Add(this.produitComboBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.produitsParCommandeDataGridView);
            this.Controls.Add(this.btnAjoutCommande);
            this.Controls.Add(this.commandeDataGridView);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.clientComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCommandes";
            this.Text = "FrmCommandes";
            this.Load += new System.EventHandler(this.FrmCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCommandesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridView commandeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAjoutCommande;
        private System.Windows.Forms.BindingSource produitsParCommandeBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitsParCommandeTableAdapter produitsParCommandeTableAdapter;
        private System.Windows.Forms.DataGridView produitsParCommandeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource totalCommandesBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.TotalCommandesTableAdapter totalCommandesTableAdapter;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.ComboBox produitComboBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btnAjouterProduit;
        private GestionCommercialHamzaDataSetTableAdapters.LigneTableAdapter ligneTableAdapter;
    }
}