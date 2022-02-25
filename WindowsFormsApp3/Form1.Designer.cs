
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label iD_categorieLabel;
            System.Windows.Forms.Label qtestockLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label proprieteLabel;
            System.Windows.Forms.Label uniteLabel;
            System.Windows.Forms.Label image_produitLabel;
            this.gestionCommercialHamzaDataSet = new WindowsFormsApp3.GestionCommercialHamzaDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager();
            this.produitListBox = new System.Windows.Forms.ListBox();
            this.iD_produitTextBox = new System.Windows.Forms.TextBox();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.image_produitTextBox = new System.Windows.Forms.TextBox();
            this.qtestockTextBox = new System.Windows.Forms.TextBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.proprieteTextBox = new System.Windows.Forms.TextBox();
            this.uniteTextBox = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategories = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChargerImage = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.categorieTableAdapter = new WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter();
            this.btnImprimer = new System.Windows.Forms.Button();
            iD_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            iD_categorieLabel = new System.Windows.Forms.Label();
            qtestockLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            proprieteLabel = new System.Windows.Forms.Label();
            uniteLabel = new System.Windows.Forms.Label();
            image_produitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_produitLabel
            // 
            iD_produitLabel.AutoSize = true;
            iD_produitLabel.Location = new System.Drawing.Point(27, 65);
            iD_produitLabel.Name = "iD_produitLabel";
            iD_produitLabel.Size = new System.Drawing.Size(101, 25);
            iD_produitLabel.TabIndex = 1;
            iD_produitLabel.Text = "ID produit:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(27, 101);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(185, 25);
            designation_produitLabel.TabIndex = 3;
            designation_produitLabel.Text = "Designation produit:";
            // 
            // iD_categorieLabel
            // 
            iD_categorieLabel.AutoSize = true;
            iD_categorieLabel.Location = new System.Drawing.Point(28, 137);
            iD_categorieLabel.Name = "iD_categorieLabel";
            iD_categorieLabel.Size = new System.Drawing.Size(103, 25);
            iD_categorieLabel.TabIndex = 7;
            iD_categorieLabel.Text = "Categorie:";
            // 
            // qtestockLabel
            // 
            qtestockLabel.AutoSize = true;
            qtestockLabel.Location = new System.Drawing.Point(28, 173);
            qtestockLabel.Name = "qtestockLabel";
            qtestockLabel.Size = new System.Drawing.Size(91, 25);
            qtestockLabel.TabIndex = 9;
            qtestockLabel.Text = "qtestock:";
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(28, 209);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(120, 25);
            prixUnitaireLabel.TabIndex = 11;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // proprieteLabel
            // 
            proprieteLabel.AutoSize = true;
            proprieteLabel.Location = new System.Drawing.Point(28, 245);
            proprieteLabel.Name = "proprieteLabel";
            proprieteLabel.Size = new System.Drawing.Size(94, 25);
            proprieteLabel.TabIndex = 13;
            proprieteLabel.Text = "propriete:";
            // 
            // uniteLabel
            // 
            uniteLabel.AutoSize = true;
            uniteLabel.Location = new System.Drawing.Point(28, 281);
            uniteLabel.Name = "uniteLabel";
            uniteLabel.Size = new System.Drawing.Size(60, 25);
            uniteLabel.TabIndex = 15;
            uniteLabel.Text = "unite:";
            // 
            // image_produitLabel
            // 
            image_produitLabel.AutoSize = true;
            image_produitLabel.Location = new System.Drawing.Point(1072, 84);
            image_produitLabel.Name = "image_produitLabel";
            image_produitLabel.Size = new System.Drawing.Size(136, 25);
            image_produitLabel.TabIndex = 5;
            image_produitLabel.Text = "Image produit:";
            // 
            // gestionCommercialHamzaDataSet
            // 
            this.gestionCommercialHamzaDataSet.DataSetName = "GestionCommercialHamzaDataSet";
            this.gestionCommercialHamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CommandeTableAdapter = null;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitListBox
            // 
            this.produitListBox.DataSource = this.produitBindingSource;
            this.produitListBox.DisplayMember = "Designation_produit";
            this.produitListBox.FormattingEnabled = true;
            this.produitListBox.ItemHeight = 25;
            this.produitListBox.Location = new System.Drawing.Point(26, 95);
            this.produitListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.produitListBox.Name = "produitListBox";
            this.produitListBox.Size = new System.Drawing.Size(448, 454);
            this.produitListBox.TabIndex = 1;
            this.produitListBox.ValueMember = "ID_produit";
            // 
            // iD_produitTextBox
            // 
            this.iD_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "ID_produit", true));
            this.iD_produitTextBox.Location = new System.Drawing.Point(218, 62);
            this.iD_produitTextBox.Name = "iD_produitTextBox";
            this.iD_produitTextBox.Size = new System.Drawing.Size(207, 30);
            this.iD_produitTextBox.TabIndex = 2;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(218, 98);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(207, 30);
            this.designation_produitTextBox.TabIndex = 4;
            // 
            // image_produitTextBox
            // 
            this.image_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Image_produit", true));
            this.image_produitTextBox.Location = new System.Drawing.Point(218, 314);
            this.image_produitTextBox.Name = "image_produitTextBox";
            this.image_produitTextBox.Size = new System.Drawing.Size(207, 30);
            this.image_produitTextBox.TabIndex = 6;
            this.image_produitTextBox.TextChanged += new System.EventHandler(this.image_produitTextBox_TextChanged);
            // 
            // qtestockTextBox
            // 
            this.qtestockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "qtestock", true));
            this.qtestockTextBox.Location = new System.Drawing.Point(219, 170);
            this.qtestockTextBox.Name = "qtestockTextBox";
            this.qtestockTextBox.Size = new System.Drawing.Size(207, 30);
            this.qtestockTextBox.TabIndex = 10;
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(219, 206);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(207, 30);
            this.prixUnitaireTextBox.TabIndex = 12;
            // 
            // proprieteTextBox
            // 
            this.proprieteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "propriete", true));
            this.proprieteTextBox.Location = new System.Drawing.Point(219, 242);
            this.proprieteTextBox.Name = "proprieteTextBox";
            this.proprieteTextBox.Size = new System.Drawing.Size(207, 30);
            this.proprieteTextBox.TabIndex = 14;
            // 
            // uniteTextBox
            // 
            this.uniteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "unite", true));
            this.uniteTextBox.Location = new System.Drawing.Point(219, 278);
            this.uniteTextBox.Name = "uniteTextBox";
            this.uniteTextBox.Size = new System.Drawing.Size(207, 30);
            this.uniteTextBox.TabIndex = 16;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(367, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 30);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Chercher";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(26, 568);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 48);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(102, 568);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(70, 48);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(328, 568);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 48);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(404, 568);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 48);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Image = global::WindowsFormsApp3.Properties.Resources.save;
            this.btnAdd.Location = new System.Drawing.Point(593, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 48);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(691, 474);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 48);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(793, 474);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 48);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(633, 552);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(96, 48);
            this.btnValidate.TabIndex = 25;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(739, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 48);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(26, 14);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(335, 30);
            this.txtFind.TabIndex = 27;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(26, 51);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(106, 29);
            this.rbContains.TabIndex = 28;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "Contient";
            this.rbContains.UseVisualStyleBackColor = true;
            this.rbContains.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Location = new System.Drawing.Point(138, 50);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(167, 29);
            this.rbStart.TabIndex = 29;
            this.rbStart.TabStop = true;
            this.rbStart.Text = "Commance par";
            this.rbStart.UseVisualStyleBackColor = true;
            this.rbStart.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(318, 51);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(156, 29);
            this.rbEnd.TabIndex = 30;
            this.rbEnd.TabStop = true;
            this.rbEnd.Text = "se termine par";
            this.rbEnd.UseVisualStyleBackColor = true;
            this.rbEnd.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(iD_produitLabel);
            this.panel1.Controls.Add(this.iD_produitTextBox);
            this.panel1.Controls.Add(designation_produitLabel);
            this.panel1.Controls.Add(this.designation_produitTextBox);
            this.panel1.Controls.Add(this.image_produitTextBox);
            this.panel1.Controls.Add(iD_categorieLabel);
            this.panel1.Controls.Add(qtestockLabel);
            this.panel1.Controls.Add(this.qtestockTextBox);
            this.panel1.Controls.Add(prixUnitaireLabel);
            this.panel1.Controls.Add(this.prixUnitaireTextBox);
            this.panel1.Controls.Add(proprieteLabel);
            this.panel1.Controls.Add(this.proprieteTextBox);
            this.panel1.Controls.Add(uniteLabel);
            this.panel1.Controls.Add(this.uniteTextBox);
            this.panel1.Location = new System.Drawing.Point(520, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 374);
            this.panel1.TabIndex = 31;
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(431, 132);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(61, 35);
            this.btnCategories.TabIndex = 26;
            this.btnCategories.Text = "...";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "ID_categorie", true));
            this.comboBox1.DataSource = this.categorieBindingSource;
            this.comboBox1.DisplayMember = "Nom_cat";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 33);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID_categorie";
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gestionCommercialHamzaDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbEnd);
            this.panel2.Controls.Add(this.rbStart);
            this.panel2.Controls.Add(this.rbContains);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.produitListBox);
            this.panel2.Location = new System.Drawing.Point(6, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 636);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1077, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnChargerImage
            // 
            this.btnChargerImage.Location = new System.Drawing.Point(1273, 474);
            this.btnChargerImage.Name = "btnChargerImage";
            this.btnChargerImage.Size = new System.Drawing.Size(170, 38);
            this.btnChargerImage.TabIndex = 34;
            this.btnChargerImage.Text = "Charger Image";
            this.btnChargerImage.UseVisualStyleBackColor = true;
            this.btnChargerImage.Click += new System.EventHandler(this.btnChargerImage_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Fichiers JPG|*.JPG| Fichiers PNG|*.PNG|Fichiers Gif|*.GIF";
            this.ofdImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImage_FileOk);
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(1092, 531);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(351, 48);
            this.btnImprimer.TabIndex = 35;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 703);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnChargerImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(image_produitLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCommercialHamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCommercialHamzaDataSet gestionCommercialHamzaDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private GestionCommercialHamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox produitListBox;
        private System.Windows.Forms.TextBox iD_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox image_produitTextBox;
        private System.Windows.Forms.TextBox qtestockTextBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox proprieteTextBox;
        private System.Windows.Forms.TextBox uniteTextBox;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChargerImage;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private GestionCommercialHamzaDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnImprimer;
    }
}

