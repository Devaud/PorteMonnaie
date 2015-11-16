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
    public partial class DebitCredit : Form
    {
        public string Motif { get; set; }
        public decimal Montant { get; set; }
        public string Categorie { get; set; }
        public string Type { get; set; }

        public DebitCredit()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            this.Motif = this.txbMotif.Text;
            this.Montant = Convert.ToDecimal(this.txbMontant.Text);
            this.Categorie = (string)this.CbxCategorie.SelectedItem;
        }
    }
}
