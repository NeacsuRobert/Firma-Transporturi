namespace proiect_paw
{
    partial class FormAdaugaSofer
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
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.userControlCategoriePermis1 = new proiect_paw.UserControlCategoriePermis();
            this.labelNumeSofer = new System.Windows.Forms.Label();
            this.labelPrenumeSofer = new System.Windows.Forms.Label();
            this.labelCNPSofer = new System.Windows.Forms.Label();
            this.buttonAdaugaSoferPEBune = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(212, 64);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(164, 20);
            this.textBoxNume.TabIndex = 0;
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(212, 126);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(164, 20);
            this.textBoxPrenume.TabIndex = 1;
            this.textBoxPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrenume_Validating);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(212, 193);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(164, 20);
            this.textBoxCNP.TabIndex = 2;
            this.textBoxCNP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCNP_Validating);
            // 
            // userControlCategoriePermis1
            // 
            this.userControlCategoriePermis1.Location = new System.Drawing.Point(-4, 249);
            this.userControlCategoriePermis1.Name = "userControlCategoriePermis1";
            this.userControlCategoriePermis1.Size = new System.Drawing.Size(462, 99);
            this.userControlCategoriePermis1.TabIndex = 3;
            // 
            // labelNumeSofer
            // 
            this.labelNumeSofer.AutoSize = true;
            this.labelNumeSofer.Location = new System.Drawing.Point(26, 64);
            this.labelNumeSofer.Name = "labelNumeSofer";
            this.labelNumeSofer.Size = new System.Drawing.Size(35, 13);
            this.labelNumeSofer.TabIndex = 4;
            this.labelNumeSofer.Text = "Nume";
            // 
            // labelPrenumeSofer
            // 
            this.labelPrenumeSofer.AutoSize = true;
            this.labelPrenumeSofer.Location = new System.Drawing.Point(26, 126);
            this.labelPrenumeSofer.Name = "labelPrenumeSofer";
            this.labelPrenumeSofer.Size = new System.Drawing.Size(49, 13);
            this.labelPrenumeSofer.TabIndex = 5;
            this.labelPrenumeSofer.Text = "Prenume";
            // 
            // labelCNPSofer
            // 
            this.labelCNPSofer.AutoSize = true;
            this.labelCNPSofer.Location = new System.Drawing.Point(32, 193);
            this.labelCNPSofer.Name = "labelCNPSofer";
            this.labelCNPSofer.Size = new System.Drawing.Size(29, 13);
            this.labelCNPSofer.TabIndex = 6;
            this.labelCNPSofer.Text = "CNP";
            // 
            // buttonAdaugaSoferPEBune
            // 
            this.buttonAdaugaSoferPEBune.Location = new System.Drawing.Point(152, 354);
            this.buttonAdaugaSoferPEBune.Name = "buttonAdaugaSoferPEBune";
            this.buttonAdaugaSoferPEBune.Size = new System.Drawing.Size(190, 48);
            this.buttonAdaugaSoferPEBune.TabIndex = 7;
            this.buttonAdaugaSoferPEBune.Text = "Adauga Sofer";
            this.buttonAdaugaSoferPEBune.UseVisualStyleBackColor = true;
            this.buttonAdaugaSoferPEBune.Click += new System.EventHandler(this.buttonAdaugaSoferPEBune_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdaugaSofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.buttonAdaugaSoferPEBune);
            this.Controls.Add(this.labelCNPSofer);
            this.Controls.Add(this.labelPrenumeSofer);
            this.Controls.Add(this.labelNumeSofer);
            this.Controls.Add(this.userControlCategoriePermis1);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Name = "FormAdaugaSofer";
            this.Text = "FormAdaugaSofer";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxCNP;
        private UserControlCategoriePermis userControlCategoriePermis1;
        private System.Windows.Forms.Label labelNumeSofer;
        private System.Windows.Forms.Label labelPrenumeSofer;
        private System.Windows.Forms.Label labelCNPSofer;
        private System.Windows.Forms.Button buttonAdaugaSoferPEBune;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}