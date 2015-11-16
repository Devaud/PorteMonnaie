using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porte_monnaie
{
    static class GestionDB
    {
        static PorteMonnaiesDataContext PorteMonnaieDb = new PorteMonnaiesDataContext();

        /// <summary>
        /// Compte le nombre de champs dans la table PorteMonnaie
        /// </summary>
        /// <returns>Nombre de champs</returns>
        static public int CountRowPorteMonnaie()
        {
            var result = from porteMonnaie in PorteMonnaieDb.PorteMonnaies select porteMonnaie;

            int count = 0;
            foreach (var porteMonnaie in result)
                count++;

            return count;
        }

        /// <summary>
        /// Ajoute un champ dans la table PorteMonnaie
        /// </summary>
        /// <param name="id">Id du porte-monnaie</param>
        /// <param name="nom">Nom du porte-monnaie</param>
        /// <param name="solde">Solde total du porte-monnaie</param>
        static public void AddFieldPorteMonnaie(int id, string nom, decimal solde)
        {
            PorteMonnaies pm = new PorteMonnaies();

            pm.IdPorteMonnaie = id;
            pm.NomPorteMonnaie = nom;
            pm.SoldePorteMonnaie = solde;

            PorteMonnaieDb.PorteMonnaies.InsertOnSubmit(pm);

            // Effectue l'ajout
            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Récupère le sole du porte-monnaie
        /// </summary>
        /// <returns>Solde du porte-monnaie</returns>
        static public decimal GetSolde()
        {
            var result = from porteMonnaie in PorteMonnaieDb.PorteMonnaies select (decimal)porteMonnaie.SoldePorteMonnaie;

            decimal solde = 0;

            foreach (var so in result)
                solde = so;


            return solde;
        }

        /// <summary>
        /// Récupère le nom de toutes les catégories
        /// </summary>
        /// <returns>tableau contenant le nom des categories</returns>
        static public string[] GetCategories()
        {
            List<string> cats = new List<string>();

            var result = from categories in PorteMonnaieDb.Categories select categories.NomCategorie;

            foreach (var cat in result)
                cats.Add(cat);

            return cats.ToArray();
        }

        /// <summary>
        /// Récupère le nom de toutes les catégories
        /// </summary>
        /// <param name="type">nom de la categorie</param>
        /// <returns></returns>
        static public string[] GetCategories(string type)
        {
            List<string> cats = new List<string>();

            var result = from categories in PorteMonnaieDb.Categories where categories.TypeCategorie == type select categories.NomCategorie;

            foreach (var cat in result)
                cats.Add(cat);

            return cats.ToArray();
        }

        /// <summary>
        /// Compte le nombre de champs dans la table Transactions
        /// </summary>
        /// <param name="idPorteMonnaie">id du porte-monnaie concerné</param>
        /// <returns></returns>
        static public int CountRowTransaction(int idPorteMonnaie)
        {
            var result = from transactions in PorteMonnaieDb.Transactions where transactions.IdPorteMonnaie == idPorteMonnaie select transactions;

            int count = 0;
            foreach (var porteMonnaie in result)
                count++;

            return count;
        }

        /// <summary>
        /// Compte le nombre de champs dans la table Categorie
        /// </summary>
        /// <param name="idPorteMonnaie">id du porte-monnaie concerné</param>
        /// <returns></returns>
        static public int CountRowCategorie()
        {
            var result = from categorie in PorteMonnaieDb.Categories select categorie;

            int count = 0;
            foreach (var categorie in result)
                count++;

            return count;
        }


        /// <summary>
        /// Effectue une transaction
        /// </summary>
        /// <param name="motif">Motif de la transaction</param>
        /// <param name="montant">Montant de la transaction</param>
        /// <param name="idCategorie">id de la catégorie</param>
        /// <param name="idPorteMonnaie">id du porte-monnaie concerné</param>
        /// <param name="type">type de transaction (Débit, Cérdit)</param>
        static public void AddTransaction(string motif, decimal montant, int idCategorie, int idPorteMonnaie, string type)
        {
            Transactions transaction = new Transactions();

            transaction.IdTransaction = CountRowTransaction(idPorteMonnaie) + 1;
            transaction.Motif = motif;
            transaction.Montant = montant;
            transaction.IdCategorie = idCategorie;
            transaction.IdPorteMonnaie = idPorteMonnaie;
            transaction.Type = type;
            
            if (type == "Débit")
                montant = -montant;
            
            UpdateMontant(idPorteMonnaie, montant);
            PorteMonnaieDb.Transactions.InsertOnSubmit(transaction);

            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Ajoute une categorie
        /// </summary>
        /// <param name="nom">Nom de la categorie</param>
        /// <param name="type">Type de la catégorie</param>
        static public void AddCategorie(string nom, string type)
        {
            Categories cat = new Categories();

            cat.IdCategorie = CountRowCategorie() + 1;
            cat.NomCategorie = nom;
            cat.TypeCategorie = type;

            PorteMonnaieDb.Categories.InsertOnSubmit(cat);

            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Met à jour le montant du porte-monnaie
        /// </summary>
        /// <param name="idPorteMonnaie">id du porte-monnaie</param>
        /// <param name="montant">Montant à enlever</param>
        static public void UpdateMontant(int idPorteMonnaie, decimal montant)
        {
            decimal total = GetSolde();
            total += montant;

            var result = from porteMonnaies in PorteMonnaieDb.PorteMonnaies where porteMonnaies.IdPorteMonnaie == idPorteMonnaie select porteMonnaies;

            foreach (var porteMonnaie in result)
                porteMonnaie.SoldePorteMonnaie = total;

            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Récupère l'id d'une catégorie selon son nom
        /// </summary>
        /// <param name="nomCategorie">Nom de la catégorie</param>
        /// <returns></returns>
        static public int GetIdCategorie(string nomCategorie)
        {
            int idCat = 0;
            var result = from categories in PorteMonnaieDb.Categories where categories.NomCategorie == nomCategorie select categories.IdCategorie;
            foreach (int id in result)
                idCat = id;

            return idCat;
        }

        /// <summary>
        /// Récupère toutes les transactions effectuée
        /// </summary>
        /// <param name="idPorteMonnaie">id du porte monnaie</param>
        /// <returns></returns>
        static public Transactions[] GetTransaction(int idPorteMonnaie)
        {
            var result = from transactions in PorteMonnaieDb.Transactions join categories in PorteMonnaieDb.Categories on transactions.IdCategorie equals categories.IdCategorie where transactions.IdPorteMonnaie == idPorteMonnaie select transactions;

            return result.ToArray();
        }

        static public decimal[] GetTransactionByCat(int idPorteMonnaie, string NomCat, string Type)
        {
            var result = from transactions in PorteMonnaieDb.Transactions
                         join categories in PorteMonnaieDb.Categories on transactions.IdCategorie
                             equals categories.IdCategorie
                         where transactions.IdPorteMonnaie == idPorteMonnaie
                         where transactions.Type == Type
                         where categories.NomCategorie == NomCat
                         select  System.Convert.ToDecimal(transactions.Montant);

            return result.ToArray();
        }

      
       
    }
 
}
