namespace proiect_paw
{
    partial class FormAdaugaMasini
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNrInmatriculare = new System.Windows.Forms.TextBox();
            this.textBoxCapacitate = new System.Windows.Forms.TextBox();
            this.userControlCategoriePermis1 = new proiect_paw.UserControlCategoriePermis();
            this.labelNrInmatriculare = new System.Windows.Forms.Label();
            this.labelCapacitate = new System.Windows.Forms.Label();
            this.buttonAdaugaMasina = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNrInmatriculare
            // 
            this.textBoxNrInmatriculare.Location = new System.Drawing.Point(151, 32);
            this.textBoxNrInmatriculare.Name = "textBoxNrInmatriculare";
            this.textBoxNrInmatriculare.Size = new System.Drawing.Size(275, 20);
            this.textBoxNrInmatriculare.TabIndex = 0;
            this.textBoxNrInmatriculare.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNrInmatriculare_Validating);
            // 
            // textBoxCapacitate
            // 
            this.textBoxCapacitate.Location = new System.Drawing.Point(151, 94);
            this.textBoxCapacitate.Name = "textBoxCapacitate";
            this.textBoxCapacitate.Size = new System.Drawing.Size(275, 20);
            this.textBoxCapacitate.TabIndex = 1;
            this.textBoxCapacitate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCapacitate_Validating);
            // 
            // userControlCategoriePermis1
            // 
            this.userControlCategoriePermis1.Location = new System.Drawing.Point(-26, 120);
            this.userControlCategoriePermis1.Name = "userControlCategoriePermis1";
            this.userControlCategoriePermis1.Size = new System.Drawing.Size(498, 97);
            this.userControlCategoriePermis1.TabIndex = 2;
            // 
            // labelNrInmatriculare
            // 
            this.labelNrInmatriculare.AutoSize = true;
            this.labelNrInmatriculare.Location = new System.Drawing.Point(13, 32);
            this.labelNrInmatriculare.Name = "labelNrInmatriculare";
            this.labelNrInmatriculare.Size = new System.Drawing.Size(101, 13);
            this.labelNrInmatriculare.TabIndex = 3;
            this.labelNrInmatriculare.Text = "Numar Inmatriculare";
            // 
            // labelCapacitate
            // 
            this.labelCapacitate.AutoSize = true;
            this.labelCapacitate.Location = new System.Drawing.Point(16, 94);
            this.labelCapacitate.Name = "labelCapacitate";
            this.labelCapacitate.Size = new System.Drawing.Size(88, 13);
            this.labelCapacitate.TabIndex = 4;
            this.labelCapacitate.Text = "Capacitate (tone)";
            // 
            // buttonAdaugaMasina
            // 
            this.buttonAdaugaMasina.Location = new System.Drawing.Point(135, 213);
            this.buttonAdaugaMasina.Name = "buttonAdaugaMasina";
            this.buttonAdaugaMasina.Size = new System.Drawing.Size(193, 23);
            this.buttonAdaugaMasina.TabIndex = 5;
            this.buttonAdaugaMasina.Text = "Adauga Masina";
            this.buttonAdaugaMasina.UseVisualStyleBackColor = true;
            this.buttonAdaugaMasina.Click += new System.EventHandler(this.buttonAdaugaMasina_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdaugaMasini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.buttonAdaugaMasina);
            this.Controls.Add(this.labelCapacitate);
            this.Controls.Add(this.labelNrInmatriculare);
            this.Controls.Add(this.userControlCategoriePermis1);
            this.Controls.Add(this.textBoxCapacitate);
            this.Controls.Add(this.textBoxNrInmatriculare);
            this.Name = "FormAdaugaMasini";
            this.Text = "FormAdaugaMasini";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNrInmatriculare;
        private System.Windows.Forms.TextBox textBoxCapacitate;
        private UserControlCategoriePermis userControlCategoriePermis1;
        private System.Windows.Forms.Label labelNrInmatriculare;
        private System.Windows.Forms.Label labelCapacitate;
        private System.Windows.Forms.Button buttonAdaugaMasina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}