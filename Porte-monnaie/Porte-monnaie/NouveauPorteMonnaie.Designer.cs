namespace Porte_monnaie
{
    partial class NouveauPorteMonnaie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxNomPorteMonnaie = new System.Windows.Forms.TextBox();
            this.TbxSoldePorteMonnaie = new System.Windows.Forms.TextBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solde :";
            // 
            // TbxNomPorteMonnaie
            // 
            this.TbxNomPorteMonnaie.Location = new System.Drawing.Point(59, 6);
            this.TbxNomPorteMonnaie.MaxLength = 50;
            this.TbxNomPorteMonnaie.Name = "TbxNomPorteMonnaie";
            this.TbxNomPorteMonnaie.Size = new System.Drawing.Size(191, 20);
            this.TbxNomPorteMonnaie.TabIndex = 2;
            // 
            // TbxSoldePorteMonnaie
            // 
            this.TbxSoldePorteMonnaie.Location = new System.Drawing.Point(59, 33);
            this.TbxSoldePorteMonnaie.Name = "TbxSoldePorteMonnaie";
            this.TbxSoldePorteMonnaie.Size = new System.Drawing.Size(191, 20);
            this.TbxSoldePorteMonnaie.TabIndex = 3;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnnuler.Location = new System.Drawing.Point(139, 59);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnnuler.Size = new System.Drawing.Size(111, 31);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAjouter.Location = new System.Drawing.Point(12, 59);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAjouter.Size = new System.Drawing.Size(111, 31);
            this.BtnAjouter.TabIndex = 5;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // NouveauPorteMonnaie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 106);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.TbxSoldePorteMonnaie);
            this.Controls.Add(this.TbxNomPorteMonnaie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NouveauPorteMonnaie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau porte-monnaie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxNomPorteMonnaie;
        private System.Windows.Forms.TextBox TbxSoldePorteMonnaie;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnAjouter;
    }
}