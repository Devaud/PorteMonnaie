namespace Porte_monnaie
{
    partial class DebitCredit
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
            this.BtnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMotif = new System.Windows.Forms.TextBox();
            this.txbMontant = new System.Windows.Forms.TextBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnValider
            // 
            this.BtnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnValider.Location = new System.Drawing.Point(38, 113);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 0;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(154, 113);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motif :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Montant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catégorie :";
            // 
            // txbMotif
            // 
            this.txbMotif.Location = new System.Drawing.Point(108, 9);
            this.txbMotif.Name = "txbMotif";
            this.txbMotif.Size = new System.Drawing.Size(121, 20);
            this.txbMotif.TabIndex = 5;
            // 
            // txbMontant
            // 
            this.txbMontant.Location = new System.Drawing.Point(108, 35);
            this.txbMontant.Name = "txbMontant";
            this.txbMontant.Size = new System.Drawing.Size(121, 20);
            this.txbMontant.TabIndex = 6;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(108, 61);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(121, 21);
            this.CbxCategorie.TabIndex = 7;
            // 
            // DebitCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 164);
            this.Controls.Add(this.CbxCategorie);
            this.Controls.Add(this.txbMontant);
            this.Controls.Add(this.txbMotif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.BtnValider);
            this.Name = "DebitCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DebitCredit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMotif;
        private System.Windows.Forms.TextBox txbMontant;
        public System.Windows.Forms.ComboBox CbxCategorie;
    }
}