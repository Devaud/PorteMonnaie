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
        public EditionCategories()
        {
            InitializeComponent();
        }

        public void ChargeCategories()
        {
            this.lbxCategoriesCredit.Items.AddRange(GestionDB.GetCategories("Credit"));
            this.lbxCategoriesDebit.Items.AddRange(GestionDB.GetCategories("Débit"));
        }

        private void btnAjouterCategories_Click(object sender, EventArgs e)
        {
            this.tbxNomCategories.Text = "";
            this.cbxType.SelectedIndex = 0;
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

        private void SupprimerItems(ListBox lbx)
        {
            if (lbx.SelectedIndex >= 0)
            {
                // A supprimer dans la base de données
                lbx.Items.RemoveAt(lbx.SelectedIndex);
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
            if (lbxCategoriesCredit.SelectedIndex >= 0)
            {
                tbxNomCategories.Text = lbxCategoriesCredit.Items[lbxCategoriesCredit.SelectedIndex].ToString();
                cbxType.SelectedIndex = cbxType.Items.IndexOf("Crédit");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            GestionDB.AddCategorie(tbxNomCategories.Text, cbxType.SelectedText);
        }
        /*
        private bool ExistCategorie(string nomCategorie)
        {
            foreach(string value )
        }*/
    }
}
