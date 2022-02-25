
namespace WindowsFormsApp3
{
    partial class FrmMenu
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
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnCommandes = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(49, 49);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(328, 42);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(49, 104);
            this.btnProduits.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(328, 42);
            this.btnProduits.TabIndex = 1;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(49, 158);
            this.btnClients.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(328, 42);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnCommandes
            // 
            this.btnCommandes.Location = new System.Drawing.Point(49, 212);
            this.btnCommandes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCommandes.Name = "btnCommandes";
            this.btnCommandes.Size = new System.Drawing.Size(328, 42);
            this.btnCommandes.TabIndex = 3;
            this.btnCommandes.Text = "Commandes";
            this.btnCommandes.UseVisualStyleBackColor = true;
            this.btnCommandes.Click += new System.EventHandler(this.btnCommandes_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(49, 499);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(328, 42);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 579);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnCommandes);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCommandes;
        private System.Windows.Forms.Button btnFermer;
    }
}