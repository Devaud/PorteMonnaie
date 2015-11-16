namespace Porte_monnaie
{
    partial class EditionCategories
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
            this.lbxCategoriesCredit = new System.Windows.Forms.ListBox();
            this.lbxCategoriesDebit = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouterCategories = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNomCategories = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCategoriesCredit
            // 
            this.lbxCategoriesCredit.FormattingEnabled = true;
            this.lbxCategoriesCredit.Items.AddRange(new object[] {
            "vfdsfds",
            "fdsbngf",
            "bndgfvgds",
            "vdfs",
            "vfds"});
            this.lbxCategoriesCredit.Location = new System.Drawing.Point(12, 12);
            this.lbxCategoriesCredit.Name = "lbxCategoriesCredit";
            this.lbxCategoriesCredit.Size = new System.Drawing.Size(265, 342);
            this.lbxCategoriesCredit.TabIndex = 0;
            this.lbxCategoriesCredit.SelectedIndexChanged += new System.EventHandler(this.lbxCategoriesCredit_SelectedIndexChanged);
            // 
            // lbxCategoriesDebit
            // 
            this.lbxCategoriesDebit.FormattingEnabled = true;
            this.lbxCategoriesDebit.Location = new System.Drawing.Point(293, 12);
            this.lbxCategoriesDebit.Name = "lbxCategoriesDebit";
            this.lbxCategoriesDebit.Size = new System.Drawing.Size(265, 342);
            this.lbxCategoriesDebit.TabIndex = 1;
            this.lbxCategoriesDebit.SelectedIndexChanged += new System.EventHandler(this.lbxCategoriesDebit_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(484, 360);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::Porte_monnaie.Properties.Resources.database_edit;
            this.btnModifier.Location = new System.Drawing.Point(110, 360);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(43, 44);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Porte_monnaie.Properties.Resources.database_delete;
            this.btnSupprimer.Location = new System.Drawing.Point(61, 360);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(43, 44);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouterCategories
            // 
            this.btnAjouterCategories.Image = global::Porte_monnaie.Properties.Resources.database_add;
            this.btnAjouterCategories.Location = new System.Drawing.Point(12, 360);
            this.btnAjouterCategories.Name = "btnAjouterCategories";
            this.btnAjouterCategories.Size = new System.Drawing.Size(43, 44);
            this.btnAjouterCategories.TabIndex = 3;
            this.btnAjouterCategories.UseVisualStyleBackColor = true;
            this.btnAjouterCategories.Click += new System.EventHandler(this.btnAjouterCategories_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.tbxNomCategories);
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorie information";
            // 
            // tbxNomCategories
            // 
            this.tbxNomCategories.Location = new System.Drawing.Point(6, 19);
            this.tbxNomCategories.Name = "tbxNomCategories";
            this.tbxNomCategories.Size = new System.Drawing.Size(233, 20);
            this.tbxNomCategories.TabIndex = 0;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Débit",
            "Crédit"});
            this.cbxType.Location = new System.Drawing.Point(6, 45);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(233, 21);
            this.cbxType.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.Location = new System.Drawing.Point(465, 16);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // EditionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouterCategories);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbxCategoriesDebit);
            this.Controls.Add(this.lbxCategoriesCredit);
            this.Name = "EditionCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditionCategories";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCategoriesCredit;
        private System.Windows.Forms.ListBox lbxCategoriesDebit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAjouterCategories;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox tbxNomCategories;
        private System.Windows.Forms.Button btnValider;
    }
}