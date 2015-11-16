namespace Porte_monnaie
{
    partial class FrmColor
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.Btnlegendcolor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clrDefaut = new System.Windows.Forms.Button();
            this.cmbPalette = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Couleur de l\'arrière plan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Couleur des légendes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Style des graphiques :";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(273, 17);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor.TabIndex = 3;
            this.btnBackColor.Text = "Choisir";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // Btnlegendcolor
            // 
            this.Btnlegendcolor.Location = new System.Drawing.Point(273, 57);
            this.Btnlegendcolor.Name = "Btnlegendcolor";
            this.Btnlegendcolor.Size = new System.Drawing.Size(75, 23);
            this.Btnlegendcolor.TabIndex = 4;
            this.Btnlegendcolor.Text = "Choisir";
            this.Btnlegendcolor.UseVisualStyleBackColor = true;
            this.Btnlegendcolor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(319, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // clrDefaut
            // 
            this.clrDefaut.Location = new System.Drawing.Point(21, 172);
            this.clrDefaut.Name = "clrDefaut";
            this.clrDefaut.Size = new System.Drawing.Size(137, 23);
            this.clrDefaut.TabIndex = 6;
            this.clrDefaut.Text = "Réinitialiser les couleurs";
            this.clrDefaut.UseVisualStyleBackColor = true;
            // 
            // cmbPalette
            // 
            this.cmbPalette.FormattingEnabled = true;
            this.cmbPalette.Location = new System.Drawing.Point(273, 99);
            this.cmbPalette.Name = "cmbPalette";
            this.cmbPalette.Size = new System.Drawing.Size(121, 21);
            this.cmbPalette.TabIndex = 7;
            // 
            // FrmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 207);
            this.Controls.Add(this.cmbPalette);
            this.Controls.Add(this.clrDefaut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btnlegendcolor);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmColor";
            this.Text = "FrmColor";
            this.Load += new System.EventHandler(this.FrmColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnBackColor;
        public System.Windows.Forms.Button Btnlegendcolor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button clrDefaut;
        public System.Windows.Forms.ComboBox cmbPalette;
    }
}