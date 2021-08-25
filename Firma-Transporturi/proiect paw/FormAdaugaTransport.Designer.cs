namespace proiect_paw
{
    partial class FormAdaugaTransport
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxOrasIncepere = new System.Windows.Forms.TextBox();
            this.textBoxOrasSosire = new System.Windows.Forms.TextBox();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdaugaTransport = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 449);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // textBoxOrasIncepere
            // 
            this.textBoxOrasIncepere.Location = new System.Drawing.Point(204, 70);
            this.textBoxOrasIncepere.Name = "textBoxOrasIncepere";
            this.textBoxOrasIncepere.Size = new System.Drawing.Size(217, 20);
            this.textBoxOrasIncepere.TabIndex = 2;
            this.textBoxOrasIncepere.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOrasIncepere_Validating);
            // 
            // textBoxOrasSosire
            // 
            this.textBoxOrasSosire.Location = new System.Drawing.Point(204, 131);
            this.textBoxOrasSosire.Name = "textBoxOrasSosire";
            this.textBoxOrasSosire.Size = new System.Drawing.Size(217, 20);
            this.textBoxOrasSosire.TabIndex = 3;
            this.textBoxOrasSosire.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOrasSosire_Validating);
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(204, 200);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(217, 20);
            this.textBoxDist.TabIndex = 4;
            this.textBoxDist.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDist_Validating);
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(204, 284);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(217, 20);
            this.textBoxCantitate.TabIndex = 5;
            this.textBoxCantitate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCantitate_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oras Plecare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oras Sosire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distanta (km)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Masina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sofer";
            // 
            // buttonAdaugaTransport
            // 
            this.buttonAdaugaTransport.Location = new System.Drawing.Point(163, 532);
            this.buttonAdaugaTransport.Name = "buttonAdaugaTransport";
            this.buttonAdaugaTransport.Size = new System.Drawing.Size(167, 50);
            this.buttonAdaugaTransport.TabIndex = 12;
            this.buttonAdaugaTransport.Text = "Adauga Transport";
            this.buttonAdaugaTransport.UseVisualStyleBackColor = true;
            this.buttonAdaugaTransport.Click += new System.EventHandler(this.buttonAdaugaTransport_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdaugaTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 606);
            this.Controls.Add(this.buttonAdaugaTransport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.textBoxOrasSosire);
            this.Controls.Add(this.textBoxOrasIncepere);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormAdaugaTransport";
            this.Text = "FormAdaugaTransport";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxOrasIncepere;
        private System.Windows.Forms.TextBox textBoxOrasSosire;
        private System.Windows.Forms.TextBox textBoxDist;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdaugaTransport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}