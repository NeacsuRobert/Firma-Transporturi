namespace proiect_paw
{
    partial class UserControlCategoriePermis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.CategoriePErmis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(177, 33);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(276, 21);
            this.comboBoxCategorie.TabIndex = 0;
            // 
            // CategoriePErmis
            // 
            this.CategoriePErmis.AutoSize = true;
            this.CategoriePErmis.Location = new System.Drawing.Point(30, 40);
            this.CategoriePErmis.Name = "CategoriePErmis";
            this.CategoriePErmis.Size = new System.Drawing.Size(86, 13);
            this.CategoriePErmis.TabIndex = 1;
            this.CategoriePErmis.Text = "Categorie Permis";
            // 
            // UserControlCategoriePermis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoriePErmis);
            this.Controls.Add(this.comboBoxCategorie);
            this.Name = "UserControlCategoriePermis";
            this.Size = new System.Drawing.Size(498, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategoriePErmis;
        public System.Windows.Forms.ComboBox comboBoxCategorie;
    }
}
