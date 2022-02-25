
namespace WindowsFormsApp3
{
    partial class FrmCommandes2
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
            this.gestionCommercialHamzaDataSet = new WindowsFormsApp3.GestionCommercialHamzaDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter();
            this.commandeDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.produitsParCommandes2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitsParCommandes2TableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitsParCommandes2TableAdapter();
            this.produitsParCommandes2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total2TableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.Total2TableAdapter();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.produitComboBox = new System.Windows.Forms.ComboBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            totalLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandes2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandes2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(1138, 338);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(44, 17);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "Total:";
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
            this.clientComboBox.Location = new System.Drawing.Point(3, 33);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(300, 24);
            this.clientComboBox.TabIndex = 1;
            this.clientComboBox.ValueMember = "ID_client";
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
            this.ID_commande,
            this.Date_commande,
            this.iDcommandeDataGridViewTextBoxColumn,
            this.datecommandeDataGridViewTextBoxColumn,
            this.designationcommandeDataGridViewTextBoxColumn,
            this.iDclientDataGridViewTextBoxColumn});
            this.commandeDataGridView.DataSource = this.commandeBindingSource;
            this.commandeDataGridView.Location = new System.Drawing.Point(10, 95);
            this.commandeDataGridView.Name = "commandeDataGridView";
            this.commandeDataGridView.ReadOnly = true;
            this.commandeDataGridView.RowHeadersWidth = 51;
            this.commandeDataGridView.RowTemplate.Height = 24;
            this.commandeDataGridView.Size = new System.Drawing.Size(448, 220);
            this.commandeDataGridView.TabIndex = 1;
            // 
            // ID_commande
            // 
            this.ID_commande.DataPropertyName = "ID_commande";
            this.ID_commande.HeaderText = "Code";
            this.ID_commande.MinimumWidth = 6;
            this.ID_commande.Name = "ID_commande";
            this.ID_commande.ReadOnly = true;
            this.ID_commande.Width = 125;
            // 
            // Date_commande
            // 
            this.Date_commande.DataPropertyName = "Date_commande";
            this.Date_commande.HeaderText = "Date";
            this.Date_commande.MinimumWidth = 6;
            this.Date_commande.Name = "Date_commande";
            this.Date_commande.ReadOnly = true;
            this.Date_commande.Width = 200;
            // 
            // iDcommandeDataGridViewTextBoxColumn
            // 
            this.iDcommandeDataGridViewTextBoxColumn.DataPropertyName = "ID_commande";
            this.iDcommandeDataGridViewTextBoxColumn.HeaderText = "ID_commande";
            this.iDcommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDcommandeDataGridViewTextBoxColumn.Name = "iDcommandeDataGridViewTextBoxColumn";
            this.iDcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDcommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // datecommandeDataGridViewTextBoxColumn
            // 
            this.datecommandeDataGridViewTextBoxColumn.DataPropertyName = "Date_commande";
            this.datecommandeDataGridViewTextBoxColumn.HeaderText = "Date_commande";
            this.datecommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datecommandeDataGridViewTextBoxColumn.Name = "datecommandeDataGridViewTextBoxColumn";
            this.datecommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datecommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationcommandeDataGridViewTextBoxColumn
            // 
            this.designationcommandeDataGridViewTextBoxColumn.DataPropertyName = "Designation_commande";
            this.designationcommandeDataGridViewTextBoxColumn.HeaderText = "Designation_commande";
            this.designationcommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationcommandeDataGridViewTextBoxColumn.Name = "designationcommandeDataGridViewTextBoxColumn";
            this.designationcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationcommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDclientDataGridViewTextBoxColumn
            // 
            this.iDclientDataGridViewTextBoxColumn.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.HeaderText = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDclientDataGridViewTextBoxColumn.Name = "iDclientDataGridViewTextBoxColumn";
            this.iDclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDclientDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // produitsParCommandes2BindingSource
            // 
            this.produitsParCommandes2BindingSource.DataMember = "Commande_ProduitsParCommandes2";
            this.produitsParCommandes2BindingSource.DataSource = this.commandeBindingSource;
            // 
            // produitsParCommandes2TableAdapter
            // 
            this.produitsParCommandes2TableAdapter.ClearBeforeFill = true;
            // 
            // produitsParCommandes2DataGridView
            // 
            this.produitsParCommandes2DataGridView.AllowUserToAddRows = false;
            this.produitsParCommandes2DataGridView.AllowUserToDeleteRows = false;
            this.produitsParCommandes2DataGridView.AutoGenerateColumns = false;
            this.produitsParCommandes2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitsParCommandes2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produitsParCommandes2DataGridView.DataSource = this.produitsParCommandes2BindingSource;
            this.produitsParCommandes2DataGridView.Location = new System.Drawing.Point(487, 95);
            this.produitsParCommandes2DataGridView.Name = "produitsParCommandes2DataGridView";
            this.produitsParCommandes2DataGridView.ReadOnly = true;
            this.produitsParCommandes2DataGridView.RowHeadersWidth = 51;
            this.produitsParCommandes2DataGridView.RowTemplate.Height = 24;
            this.produitsParCommandes2DataGridView.Size = new System.Drawing.Size(855, 220);
            this.produitsParCommandes2DataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nom_cat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom_cat";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_produit";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_produit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Designation_produit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Designation_produit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qte";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qte";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // total2BindingSource
            // 
            this.total2BindingSource.DataMember = "FK_Ligne_Commande2";
            this.total2BindingSource.DataSource = this.commandeBindingSource;
            // 
            // total2TableAdapter
            // 
            this.total2TableAdapter.ClearBeforeFill = true;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.White;
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total2BindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(1242, 335);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
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
            this.produitComboBox.Location = new System.Drawing.Point(478, 65);
            this.produitComboBox.Name = "produitComboBox";
            this.produitComboBox.Size = new System.Drawing.Size(300, 24);
            this.produitComboBox.TabIndex = 8;
            this.produitComboBox.ValueMember = "ID_produit";
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(789, 40);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(87, 17);
            prixUnitaireLabel.TabIndex = 8;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(792, 65);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(100, 22);
            this.prixUnitaireTextBox.TabIndex = 9;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(908, 65);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 22);
            this.txtQte.TabIndex = 10;
            this.txtQte.Text = "1";
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1242, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCommandes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 686);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(prixUnitaireLabel);
            this.Controls.Add(this.prixUnitaireTextBox);
            this.Controls.Add(this.produitComboBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.produitsParCommandes2DataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.commandeDataGridView);
            this.Controls.Add(this.clientComboBox);
            this.Name = "FrmCommandes2";
            this.Text = "FrmCommandes2";
            this.Load += new System.EventHandler(this.FrmCommandes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandes2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandes2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total2BindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridView commandeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_commande;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource produitsParCommandes2BindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitsParCommandes2TableAdapter produitsParCommandes2TableAdapter;
        private System.Windows.Forms.DataGridView produitsParCommandes2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource total2BindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.Total2TableAdapter total2TableAdapter;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.ComboBox produitComboBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button button3;
    }
}