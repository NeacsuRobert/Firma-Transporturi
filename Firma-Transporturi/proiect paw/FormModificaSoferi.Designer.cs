namespace proiect_paw
{
    partial class FormModificaSoferi
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
            this.buttonModificaSofer = new System.Windows.Forms.Button();
            this.labelCNPSofer = new System.Windows.Forms.Label();
            this.labelPrenumeSofer = new System.Windows.Forms.Label();
            this.labelNumeSofer = new System.Windows.Forms.Label();
            this.userControlCategoriePermis1 = new proiect_paw.UserControlCategoriePermis();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonModificaSofer
            // 
            this.buttonModificaSofer.Location = new System.Drawing.Point(325, 346);
            this.buttonModificaSofer.Name = "buttonModificaSofer";
            this.buttonModificaSofer.Size = new System.Drawing.Size(190, 48);
            this.buttonModificaSofer.TabIndex = 15;
            this.buttonModificaSofer.Text = "Modifica Sofer";
            this.buttonModificaSofer.UseVisualStyleBackColor = true;
            this.buttonModificaSofer.Click += new System.EventHandler(this.buttonModificaSofer_Click);
            // 
            // labelCNPSofer
            // 
            this.labelCNPSofer.AutoSize = true;
            this.labelCNPSofer.Location = new System.Drawing.Point(205, 185);
            this.labelCNPSofer.Name = "labelCNPSofer";
            this.labelCNPSofer.Size = new System.Drawing.Size(29, 13);
            this.labelCNPSofer.TabIndex = 14;
            this.labelCNPSofer.Text = "CNP";
            // 
            // labelPrenumeSofer
            // 
            this.labelPrenumeSofer.AutoSize = true;
            this.labelPrenumeSofer.Location = new System.Drawing.Point(199, 118);
            this.labelPrenumeSofer.Name = "labelPrenumeSofer";
            this.labelPrenumeSofer.Size = new System.Drawing.Size(49, 13);
            this.labelPrenumeSofer.TabIndex = 13;
            this.labelPrenumeSofer.Text = "Prenume";
            // 
            // labelNumeSofer
            // 
            this.labelNumeSofer.AutoSize = true;
            this.labelNumeSofer.Location = new System.Drawing.Point(199, 56);
            this.labelNumeSofer.Name = "labelNumeSofer";
            this.labelNumeSofer.Size = new System.Drawing.Size(35, 13);
            this.labelNumeSofer.TabIndex = 12;
            this.labelNumeSofer.Text = "Nume";
            // 
            // userControlCategoriePermis1
            // 
            this.userControlCategoriePermis1.Location = new System.Drawing.Point(169, 241);
            this.userControlCategoriePermis1.Name = "userControlCategoriePermis1";
            this.userControlCategoriePermis1.Size = new System.Drawing.Size(462, 99);
            this.userControlCategoriePermis1.TabIndex = 11;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(385, 185);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(164, 20);
            this.textBoxCNP.TabIndex = 10;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(385, 118);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(164, 20);
            this.textBoxPrenume.TabIndex = 9;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(385, 56);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(164, 20);
            this.textBoxNume.TabIndex = 8;
            // 
            // FormModificaSoferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModificaSofer);
            this.Controls.Add(this.labelCNPSofer);
            this.Controls.Add(this.labelPrenumeSofer);
            this.Controls.Add(this.labelNumeSofer);
            this.Controls.Add(this.userControlCategoriePermis1);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Name = "FormModificaSoferi";
            this.Text = "FormModificaSoferi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificaSofer;
        private System.Windows.Forms.Label labelCNPSofer;
        private System.Windows.Forms.Label labelPrenumeSofer;
        private System.Windows.Forms.Label labelNumeSofer;
        public UserControlCategoriePermis userControlCategoriePermis1;
        public System.Windows.Forms.TextBox textBoxCNP;
        public System.Windows.Forms.TextBox textBoxPrenume;
        public System.Windows.Forms.TextBox textBoxNume;
    }
}