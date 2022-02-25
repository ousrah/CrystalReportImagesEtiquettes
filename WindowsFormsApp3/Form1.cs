using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);

        }

        private void activate(bool v)
        {
            panel1.Enabled = !v;
            panel2.Enabled = v;
            btnAdd.Visible = v;
            btnEdit.Visible = v;
            btnRemove.Visible = v;
            btnValidate.Visible = !v;
            btnCancel.Visible = !v;
            btnChargerImage.Visible = !v;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestionCommercialHamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Produit);
            activate(true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (produitListBox.SelectedIndex == produitListBox.Items.Count - 1)

                produitBindingSource.MoveFirst();

            else
                produitBindingSource.MoveNext();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (produitListBox.SelectedIndex == 0)

                produitBindingSource.MoveLast();

            else
                produitBindingSource.MovePrevious();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            produitBindingSource.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            produitBindingSource.MoveFirst();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string start = "%";
            string end = "%";

            if (rbStart.Checked) start = "";
            if (rbEnd.Checked) end = "";

            produitBindingSource.Filter = "designation_produit like '" + start + txtFind.Text + end + "'";



        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produitBindingSource.AddNew();
            activate(false);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            produitBindingSource.CancelEdit();
            activate(true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous certain de supprimer ce produit?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                produitBindingSource.RemoveCurrent();
                this.Validate();
                this.produitBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCommercialHamzaDataSet);
            }
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnFind.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activate(false);
        }

        private void image_produitTextBox_TextChanged(object sender, EventArgs e)
        {
            if (image_produitTextBox.Text == "")
                pictureBox1.Load("photos/empty.png");
            else
                pictureBox1.Load("photos/" + image_produitTextBox.Text);
        }

        private void btnChargerImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                Random r = new Random();
                string name = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + (Math.Abs(r.Next()) * 1000);
                string ext = Path.GetExtension(ofdImage.FileName);
                File.Copy(ofdImage.FileName, "photos/" + name + ext);
                image_produitTextBox.Text = name + ext;
            }
        }

        private void ofdImage_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories f = new FrmCategories();
            //   if (f.ShowDialog() == DialogResult.OK)
            f.ShowDialog();
            this.categorieTableAdapter.Fill(this.gestionCommercialHamzaDataSet.Categorie);

            //    else
            //        MessageBox.Show("aucune action");


        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            string ch = Application.StartupPath + @"\photos\";

            photos cr = new photos();
                 cr.Refresh(); 
            cr.SetDataSource(gestionCommercialHamzaDataSet);
 
            cr.SetParameterValue("chemin", ch);
       //   
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }
    }
}
