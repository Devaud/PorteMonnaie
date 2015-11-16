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
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
            cmbPalette.Items.Add("Bright");
            cmbPalette.Items.Add("Grayscale");
            cmbPalette.Items.Add("Excel");
            cmbPalette.Items.Add("Light");
            cmbPalette.Items.Add("Pastel");
            cmbPalette.Items.Add("EarthTones");
            cmbPalette.Items.Add("SemiTransparent");
            cmbPalette.Items.Add("Berry");
            cmbPalette.Items.Add("Chocolate");
            cmbPalette.Items.Add("Fire");
            cmbPalette.Items.Add("SeaGreen");
            cmbPalette.Items.Add("BrightPastel");


        }

        private void ShowPalette(object sender)
        {
            ColorDialog clDlg = new ColorDialog();
            DialogResult DlgRsl = new DialogResult();
            DlgRsl = clDlg.ShowDialog();
            if (DlgRsl != DialogResult.Cancel)
            {
                (sender as Button).BackColor = clDlg.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ShowPalette(sender);
        }

        private void clrDefaut_Click(object sender, EventArgs e)
        {
            btnBackColor.BackColor = Color.Green;
            Btnlegendcolor.BackColor = Color.CadetBlue;
            cmbPalette.SelectedIndex = 2;
        }

        private void FrmColor_Load(object sender, EventArgs e)
        {
            clrDefaut_Click(sender, e);
        }


    }
}
