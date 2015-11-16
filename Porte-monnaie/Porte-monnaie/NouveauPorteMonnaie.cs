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
    public partial class NouveauPorteMonnaie : Form
    {
        public decimal Solde { get; set; }
        public string Nom { get; set; }

        public NouveauPorteMonnaie()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            this.Nom = TbxNomPorteMonnaie.Text;
            this.Solde = decimal.Parse(TbxSoldePorteMonnaie.Text);
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
