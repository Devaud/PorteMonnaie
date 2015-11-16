namespace Porte_monnaie
{
    partial class Graphique
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
            this.pnlDepense = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.PnlCredit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDepense
            // 
            this.pnlDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDepense.Location = new System.Drawing.Point(12, 12);
            this.pnlDepense.Name = "pnlDepense";
            this.pnlDepense.Size = new System.Drawing.Size(388, 351);
            this.pnlDepense.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(787, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // PnlCredit
            // 
            this.PnlCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCredit.Location = new System.Drawing.Point(411, 12);
            this.PnlCredit.Name = "PnlCredit";
            this.PnlCredit.Size = new System.Drawing.Size(388, 351);
            this.PnlCredit.TabIndex = 1;
            // 
            // Graphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 394);
            this.Controls.Add(this.PnlCredit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlDepense);
            this.Name = "Graphique";
            this.Text = "Graphique";
            this.Load += new System.EventHandler(this.Graphique_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepense;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel PnlCredit;
    }
}