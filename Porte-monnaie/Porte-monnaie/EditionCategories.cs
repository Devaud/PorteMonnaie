using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porte_monnaie
{
    public partial class EditionCategories : Form
    {
        private bool Modification { set; get; }
        private string AncienNom { set; get; }

        public EditionCategories()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge les listes avec les catégories se trouvant dans la base de données
        /// </summary>
        public void ChargeCategories()
        {
            this.lbxCategoriesDebit.Items.Clear();
            this.lbxCategoriesCredit.Items.Clear();
            this.lbxCategoriesCredit.Items.AddRange(GestionDB.GetCategories("Crédit"));
            this.lbxCategoriesDebit.Items.AddRange(GestionDB.GetCategories("Débit"));
            this.Size = new Size(586, 447);
        }

        private void btnAjouterCategories_Click(object sender, EventArgs e)
        {
            this.tbxNomCategories.Text = "";
            this.cbxType.SelectedIndex = 0;
            this.Modification = false;
            this.Size = new Size(586, 540);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.SupprimerItems(this.lbxCategoriesCredit);
            this.SupprimerItems(this.lbxCategoriesDebit);
        }

        private void lbxCategoriesCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ControlIndex(lbxCategoriesDebit, lbxCategoriesCredit);

        }

        private void lbxCategoriesDebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ControlIndex(lbxCategoriesCredit, lbxCategoriesDebit);
        }

        /// <summary>
        /// Supprime une catégorie
        /// </summary>
        /// <param name="lbx">Liste contenant l'élément à supprimer</param>
        private void SupprimerItems(ListBox lbx)
        {
            if (lbx.SelectedIndex >= 0)
            {
                // A supprimer dans la base de données
                GestionDB.DeleteCategorie(lbx.Items[lbx.SelectedIndex].ToString());
                MessageBox.Show("Catégorie supprimée avec succès !");
                this.ChargeCategories();
            }
        }

        /// <summary>
        /// Contrôle l'index d'une listBox pour que se soit le bont qui soit cocher
        /// </summary>
        /// <param name="lbx">ListBox où l'index sera enlevé</param>
        /// <param name="lbxSecond">ListBox du nouvelle index</param>
        private void ControlIndex(ListBox lbx, ListBox lbxSecond)
        {
            if (lbx.SelectedIndex >= 0)
            {
                int oldIndex = lbxSecond.SelectedIndex;
                lbx.SelectedIndex = -1;
                lbxSecond.SelectedIndex = oldIndex;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Size = new Size(586, 540);
            this.Modifier(lbxCategoriesCredit);
            this.Modifier(lbxCategoriesDebit);
        }

        /// <summary>
        /// Initialise la modification
        /// </summary>
        /// <param name="lbx">List contenant l'élément à modifier</param>
        private void Modifier(ListBox lbx)
        {
            if (lbx.SelectedIndex >= 0)
            {
                tbxNomCategories.Text = lbx.Items[lbx.SelectedIndex].ToString();
                cbxType.SelectedIndex = (lbx.Name == "lbxCategoriesCredit") ? cbxType.Items.IndexOf("Crédit") : cbxType.Items.IndexOf("Débit");
                AncienNom = tbxNomCategories.Text;
                this.Modification = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!this.Modification)
            {
                if (!this.ExistCategorie(tbxNomCategories.Text))
                {
                    // Ajout une catégorie
                    GestionDB.AddCategorie(tbxNomCategories.Text, cbxType.Items[cbxType.SelectedIndex].ToString());
                    this.ChargeCategories();
                }
            }
            else
            {
                // Modifier une catégorie
                GestionDB.UpdateCategorie(tbxNomCategories.Text, cbxType.Items[cbxType.SelectedIndex].ToString(), AncienNom);
                this.ChargeCategories();
            }

        }

        /// <summary>
        /// Test su le nom de la catégorie existe déjà
        /// </summary>
        /// <param name="nomCategorie">Nom de la catégorie à ajouter</param>
        /// <returns></returns>
        private bool ExistCategorie(string nomCategorie)
        {
            foreach (string value in lbxCategoriesCredit.Items)
                if (value == nomCategorie)
                    return true;

            foreach (string value in lbxCategoriesDebit.Items)
                if (value == nomCategorie)
                    return true;


            return false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Size = new Size(586, 447);
        }
    }
}
