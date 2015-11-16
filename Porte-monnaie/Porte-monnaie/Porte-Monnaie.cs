using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Porte_monnaie
{
    public partial class FrmMain : Form
    {
        private const decimal ORANGE_ZONE = 50;
        private const decimal RED_ZONE = 1;

        public FrmMain()
        {
            InitializeComponent();
            //ajoutes nos noms dans le status bar
            tStstbNames.Text = "Camuglia Lucien && Devaud Alan -- T.IS-E1";

            // Compte le nombre de champs existant
            int count = GestionDB.CountRowPorteMonnaie();

            // S'il n'y a aucun porte-monnaie on en rajoute un
            if (count <= 0)
            {
                MessageBox.Show("Il n'exist acctuellement aucun porte-monnaie ! \r\nVeuillez en créer un !");

                NouveauPorteMonnaie nvPorteMonnaie = new NouveauPorteMonnaie();
                DialogResult dr = nvPorteMonnaie.ShowDialog(); // Affiche la fenêtre pour la création du porte-monnaie
                if (dr == DialogResult.OK)
                    GestionDB.AddFieldPorteMonnaie(count + 1, nvPorteMonnaie.Nom, nvPorteMonnaie.Solde); // Ajout le porte-monnaie à la base de données
            }

            this.UpdateAffichage();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Graphique frmGraphique = new Graphique();
            frmGraphique.ShowDialog();
        }

        private void BtnDepense_Click(object sender, EventArgs e)
        {
            DebitCredit frmDebitCredit = new DebitCredit();
            string[] cats = GestionDB.GetCategories("Débit"); // Récupère toute les catégories

            foreach (string name in cats)
                frmDebitCredit.CbxCategorie.Items.Add(name); // Ajoute les catégorie dans la combobox
            frmDebitCredit.CbxCategorie.SelectedIndex = 0;
            frmDebitCredit.Type = "Débit";

            DialogResult dr = frmDebitCredit.ShowDialog();

            if (dr == DialogResult.OK)
            {
                int idCat = GestionDB.GetIdCategorie(frmDebitCredit.Categorie); // Récupère l'id de la catégorie
                GestionDB.AddTransaction(frmDebitCredit.Motif, frmDebitCredit.Montant, idCat, 1, frmDebitCredit.Type); // Ajoute la transaction
                this.UpdateAffichage();
            }
        }

        /// <summary>
        /// Affiche les transactions effectuées
        /// </summary>
        private void AfficheTransaction()
        {
            Transactions[] transactions = GestionDB.GetTransaction(1);
            List<string> listTransactions = new List<string>();
            foreach (Transactions tr in transactions)
            {
                string item = AjusterText(tr.Motif, 20) + " " + AjusterText(tr.Categories.NomCategorie, 20) + " ";
                item += (tr.Type == "Débit") ? "-" : "+";
                item += tr.Montant;
                
                listTransactions.Add(item);
            }

            lbxTransactions.Items.Clear();
            lbxTransactions.Items.AddRange(listTransactions.ToArray());
        }

        /// <summary>
        /// Ajuste la taille du text
        /// </summary>
        /// <param name="text">Text à modifier</param>
        /// <param name="tailleText">Taille du texte</param>
        /// <returns></returns>
        private string AjusterText(string text, int tailleText)
        {
            while (text.Length < tailleText)
            {
                text += " ";
            }

            return text;
        }

        /// <summary>
        /// Affiche le solde du porte-monnaie
        /// </summary>
        private void AfficheSolde()
        {
            // Récupère le solde total
            decimal solde = GestionDB.GetSolde();

            // Modifie la couleur du label selon le solde
            if (solde > RED_ZONE && solde <= ORANGE_ZONE)
                this.lblSoldeTotal.ForeColor = Color.Orange;
            else if (solde <= RED_ZONE)
                this.lblSoldeTotal.ForeColor = Color.Red;
            else
                this.lblSoldeTotal.ForeColor = Color.Black;

            // Affiche le solde
            this.lblSoldeTotal.Text = solde.ToString();
        }

        /// <summary>
        /// Met à jour l'affichage
        /// </summary>
        private void UpdateAffichage()
        {
            this.AfficheTransaction();
            this.AfficheSolde();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            DebitCredit frmDebitCredit = new DebitCredit();
            string[] cats = GestionDB.GetCategories("Crédit"); // Récupère toute les catégories

            foreach (string name in cats)
                frmDebitCredit.CbxCategorie.Items.Add(name); // Ajoute les catégorie dans la combobox
            frmDebitCredit.CbxCategorie.SelectedIndex = 0;
            frmDebitCredit.Type = "Crédit";

            DialogResult dr = frmDebitCredit.ShowDialog();

            if (dr == DialogResult.OK)
            {
                int idCat = GestionDB.GetIdCategorie(frmDebitCredit.Categorie); // Récupère l'id de la catégorie
                GestionDB.AddTransaction(frmDebitCredit.Motif, frmDebitCredit.Montant, idCat, 1, frmDebitCredit.Type); // Ajoute la transaction
                this.UpdateAffichage();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditionCategories frmCat = new EditionCategories();

            // Récupère les catégories et initialise les lists de la fenêtre avec
            frmCat.ChargeCategories();

            frmCat.ShowDialog();
        }
    }
}
