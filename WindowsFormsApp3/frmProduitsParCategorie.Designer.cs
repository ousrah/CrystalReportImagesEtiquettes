
namespace WindowsFormsApp3
{
    partial class frmProduitsParCategorie
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
            System.Windows.Forms.Label iD_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label image_produitLabel;
            System.Windows.Forms.Label qtestockLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label proprieteLabel;
            System.Windows.Forms.Label uniteLabel;
            this.gestionCommercialHamzaDataSet = new WindowsFormsApp3.GestionCommercialHamzaDataSet();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.produitTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitListBox = new System.Windows.Forms.ListBox();
            this.iD_produitTextBox = new System.Windows.Forms.TextBox();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.image_produitTextBox = new System.Windows.Forms.TextBox();
            this.qtestockTextBox = new System.Windows.Forms.TextBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.proprieteTextBox = new System.Windows.Forms.TextBox();
            this.uniteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            image_produitLabel = new System.Windows.Forms.Label();
            qtestockLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            proprieteLabel = new System.Windows.Forms.Label();
            uniteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_produitLabel
            // 
            iD_produitLabel.AutoSize = true;
            iD_produitLabel.Location = new System.Drawing.Point(488, 147);
            iD_produitLabel.Name = "iD_produitLabel";
            iD_produitLabel.Size = new System.Drawing.Size(73, 17);
            iD_produitLabel.TabIndex = 2;
            iD_produitLabel.Text = "ID produit:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(488, 175);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(135, 17);
            designation_produitLabel.TabIndex = 4;
            designation_produitLabel.Text = "Designation produit:";
            // 
            // image_produitLabel
            // 
            image_produitLabel.AutoSize = true;
            image_produitLabel.Location = new System.Drawing.Point(488, 203);
            image_produitLabel.Name = "image_produitLabel";
            image_produitLabel.Size = new System.Drawing.Size(98, 17);
            image_produitLabel.TabIndex = 6;
            image_produitLabel.Text = "Image produit:";
            // 
            // qtestockLabel
            // 
            qtestockLabel.AutoSize = true;
            qtestockLabel.Location = new System.Drawing.Point(488, 231);
            qtestockLabel.Name = "qtestockLabel";
            qtestockLabel.Size = new System.Drawing.Size(65, 17);
            qtestockLabel.TabIndex = 10;
            qtestockLabel.Text = "qtestock:";
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(488, 259);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(87, 17);
            prixUnitaireLabel.TabIndex = 12;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // proprieteLabel
            // 
            proprieteLabel.AutoSize = true;
            proprieteLabel.Location = new System.Drawing.Point(488, 287);
            proprieteLabel.Name = "proprieteLabel";
            proprieteLabel.Size = new System.Drawing.Size(69, 17);
            proprieteLabel.TabIndex = 14;
            proprieteLabel.Text = "propriete:";
            // 
            // uniteLabel
            // 
            uniteLabel.AutoSize = true;
            uniteLabel.Location = new System.Drawing.Point(488, 315);
            uniteLabel.Name = "uniteLabel";
            uniteLabel.Size = new System.Drawing.Size(43, 17);
            uniteLabel.TabIndex = 16;
            uniteLabel.Text = "unite:";
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = this.categorieTableAdapter;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DataSource = this.categorieBindingSource;
            this.categorieComboBox.DisplayMember = "Nom_cat";
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(136, 55);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(300, 24);
            this.categorieComboBox.TabIndex = 1;
            this.categorieComboBox.ValueMember = "ID_categorie";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "FK_Produit_Categorie";
            this.produitBindingSource.DataSource = this.categorieBindingSource;
            // 
            // produitListBox
            // 
            this.produitListBox.DataSource = this.produitBindingSource;
            this.produitListBox.DisplayMember = "Designation_produit";
            this.produitListBox.FormattingEnabled = true;
            this.produitListBox.ItemHeight = 16;
            this.produitListBox.Location = new System.Drawing.Point(141, 117);
            this.produitListBox.Name = "produitListBox";
            this.produitListBox.Size = new System.Drawing.Size(300, 212);
            this.produitListBox.TabIndex = 1;
            this.produitListBox.ValueMember = "ID_produit";
            // 
            // iD_produitTextBox
            // 
            this.iD_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "ID_produit", true));
            this.iD_produitTextBox.Location = new System.Drawing.Point(629, 144);
            this.iD_produitTextBox.Name = "iD_produitTextBox";
            this.iD_produitTextBox.Size = new System.Drawing.Size(121, 22);
            this.iD_produitTextBox.TabIndex = 3;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(629, 172);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(121, 22);
            this.designation_produitTextBox.TabIndex = 5;
            // 
            // image_produitTextBox
            // 
            this.image_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Image_produit", true));
            this.image_produitTextBox.Location = new System.Drawing.Point(629, 200);
            this.image_produitTextBox.Name = "image_produitTextBox";
            this.image_produitTextBox.Size = new System.Drawing.Size(121, 22);
            this.image_produitTextBox.TabIndex = 7;
            // 
            // qtestockTextBox
            // 
            this.qtestockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "qtestock", true));
            this.qtestockTextBox.Location = new System.Drawing.Point(629, 228);
            this.qtestockTextBox.Name = "qtestockTextBox";
            this.qtestockTextBox.Size = new System.Drawing.Size(121, 22);
            this.qtestockTextBox.TabIndex = 11;
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(629, 256);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(121, 22);
            this.prixUnitaireTextBox.TabIndex = 13;
            // 
            // proprieteTextBox
            // 
            this.proprieteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "propriete", true));
            this.proprieteTextBox.Location = new System.Drawing.Point(629, 284);
            this.proprieteTextBox.Name = "proprieteTextBox";
            this.proprieteTextBox.Size = new System.Drawing.Size(121, 22);
            this.proprieteTextBox.TabIndex = 15;
            // 
            // uniteTextBox
            // 
            this.uniteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "unite", true));
            this.uniteTextBox.Location = new System.Drawing.Point(629, 312);
            this.uniteTextBox.Name = "uniteTextBox";
            this.uniteTextBox.Size = new System.Drawing.Size(121, 22);
            this.uniteTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmProduitsParCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_produitLabel);
            this.Controls.Add(this.iD_produitTextBox);
            this.Controls.Add(designation_produitLabel);
            this.Controls.Add(this.designation_produitTextBox);
            this.Controls.Add(image_produitLabel);
            this.Controls.Add(this.image_produitTextBox);
            this.Controls.Add(qtestockLabel);
            this.Controls.Add(this.qtestockTextBox);
            this.Controls.Add(prixUnitaireLabel);
            this.Controls.Add(this.prixUnitaireTextBox);
            this.Controls.Add(proprieteLabel);
            this.Controls.Add(this.proprieteTextBox);
            this.Controls.Add(uniteLabel);
            this.Controls.Add(this.uniteTextBox);
            this.Controls.Add(this.produitListBox);
            this.Controls.Add(this.categorieComboBox);
            this.Name = "frmProduitsParCategorie";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.ListBox produitListBox;
        private System.Windows.Forms.TextBox iD_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox image_produitTextBox;
        private System.Windows.Forms.TextBox qtestockTextBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox proprieteTextBox;
        private System.Windows.Forms.TextBox uniteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}