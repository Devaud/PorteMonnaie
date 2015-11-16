using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Porte_monnaie
{
    public partial class Graphique : Form
    {
        Chart CammembertDepense = new Chart();
        Chart CammembertCredit = new Chart();
        //choix du nom volontaire afin que tout le fond change de couleur
        Color BackColor = Color.Green;
        Color LegendColor = Color.CadetBlue;
        String PaletteStyle = "Excel";

        public Graphique()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Charge les graphiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Graphique_Load(object sender, EventArgs e)
        {
            InitialisesGraphique("Débit", CammembertDepense);
            ChargeGraphique("Débit", pnlDepense, CammembertDepense);
            InitialisesGraphique("Crédit", CammembertCredit);
            ChargeGraphique("Crédit", PnlCredit, CammembertCredit);
        }

        /// <summary>
        /// initialisation du graphique
        /// </summary>
        /// <param name="motif">Crédit ou Débit</param>
        /// <param name="cammembert">Chart</param>
        void InitialisesGraphique(string motif, Chart cammembert)
        {
            //crée l'aire dans laquelle apparaitra le graphique
            ChartArea Aire = new ChartArea();
            //crée la legende du graphique (carré en haut a droite)
            Legend Legende = new Legend() { BackColor = LegendColor, ForeColor = Color.Black, Title = "Catégories" };
            Aire.Name = "AireDuCammembert";
            cammembert.ChartAreas.Add(Aire);
            cammembert.Dock = System.Windows.Forms.DockStyle.Fill;
            Legende.Name = "Etat des " + motif;
            cammembert.Legends.Add(Legende);
            cammembert.Location = new System.Drawing.Point(0, 50);
        }

        /// <summary>
        /// charge le graphique, définit les parts du cammembert et le nom des catégories
        /// </summary>
        /// <param name="motif">Crédit ou Débit</param>
        /// <param name="zone">Panel dans lequel le graphique sera affiché</param>
        /// <param name="cammembert">Chart</param>
        void ChargeGraphique(string motif, Panel zone, Chart cammembert)
        {

            //supprime toutes les parts du cammembert
            cammembert.Series.Clear();

            switch (PaletteStyle)
            {
                case "Bright":
                    cammembert.Palette = ChartColorPalette.Bright;
                    break;
                case "Grayscale":
                    cammembert.Palette = ChartColorPalette.Grayscale;
                    break;
                case "Excel":
                    cammembert.Palette = ChartColorPalette.Excel;
                    break;
                case "Light":
                    cammembert.Palette = ChartColorPalette.Light;
                    break;
                case "Pastel":
                    cammembert.Palette = ChartColorPalette.Pastel;
                    break;
                case "EarthTones":
                    cammembert.Palette = ChartColorPalette.EarthTones;
                    break;
                case "SemiTransparent":
                    cammembert.Palette = ChartColorPalette.SemiTransparent;
                    break;
                case "Berry":
                    cammembert.Palette = ChartColorPalette.Berry;
                    break;
                case "Chocolate":
                    cammembert.Palette = ChartColorPalette.Chocolate;
                    break;
                case "Fire":
                    cammembert.Palette = ChartColorPalette.Fire;
                    break;
                case "SeaGreen":
                    cammembert.Palette = ChartColorPalette.SeaGreen;
                    break;
                case "BrightPastel":
                    cammembert.Palette = ChartColorPalette.BrightPastel;
                    break;
                default:
                    cammembert.Palette = ChartColorPalette.Excel;
                    break;
            }

            cammembert.BackColor = BackColor;
            //titre du graphique
            cammembert.Titles.Add("Etat des " + motif);
            cammembert.ChartAreas[0].BackColor = Color.Transparent;
            //crée la serie
            Series series1 = new Series
            {
                Name = motif,
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Pie
            };

            cammembert.Series.Add(series1);
            string[,] maserie = RecupereInfo(motif);


            for (int i = 0; i < maserie.Length / 2; i++)
            {
                series1.Points.Add(System.Convert.ToDouble(maserie[i, 1]));

                var point = series1.Points[i];
                if (System.Convert.ToDouble(maserie[i, 1]) > 0)
                {
                    point.AxisLabel = maserie[i, 1];
                }
                point.LegendText = maserie[i, 0];



            }

            cammembert.Invalidate();
            zone.Controls.Add(cammembert);
        }

        /// <summary>
        /// Recupère les information de Débit ou crédit
        /// </summary>        
        /// <param name="type">Débit / Crédit</param>
        /// </summary>
        /// <returns>Tableau avec le nom de catégorie et le montant dépensé pour celle-ci</returns>        
        string[,] RecupereInfo(string type)
        {
            string[] categories = GestionDB.GetCategories(type);
            decimal depenseTotal = 0;
            string[,] serie = new string[categories.Length, 2];

            for (int i = 0; i < categories.Length; i++)
            {
                depenseTotal = 0;
                decimal[] transactions;
                transactions = GestionDB.GetTransactionByCat(1, categories[i], type);

                foreach (var trans in transactions)
                {
                    depenseTotal += trans;
                }
                serie[i, 0] = categories[i];
                serie[i, 1] = depenseTotal.ToString().Substring(0, depenseTotal.ToString().IndexOf('.') + 2);

            }


            return serie;
        }

        private void Graphique_Resize(object sender, EventArgs e)
        {
            int centre = this.Width / 2;
            pnlDepense.Width = centre;
            PnlCredit.Location = new Point(centre, 12);
            PnlCredit.Width = centre - 12;
        }

        private void choixDesCouleursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColor frmc = new FrmColor();
            DialogResult DlgRslFrmC = frmc.ShowDialog();

            if (DlgRslFrmC != DialogResult.Cancel)
            {
                this.PaletteStyle = frmc.cmbPalette.Text;
                this.BackColor = frmc.btnBackColor.BackColor;
                this.LegendColor = frmc.Btnlegendcolor.BackColor;

                ResetChart(CammembertCredit);
                ResetChart(CammembertDepense);                 
                 
                Graphique_Load(sender,e);
            }
        }

        private void ResetChart(Chart cammembert)
        {
            cammembert.ChartAreas.Clear();
            cammembert.Series.Clear();
            cammembert.Legends.Clear();
            cammembert.Titles.Clear();
        }
    }
}
