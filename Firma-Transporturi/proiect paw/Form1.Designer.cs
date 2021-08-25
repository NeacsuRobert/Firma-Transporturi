namespace proiect_paw
{
    partial class Form1
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
            this.firmatransporturiDataSet = new proiect_paw.firmatransporturiDataSet();
            this.soferiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soferiTableAdapter = new proiect_paw.firmatransporturiDataSetTableAdapters.soferiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewTransporturi = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSosire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDistanta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrInmatriculare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdaugaTransport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGrafic = new System.Windows.Forms.Button();
            this.buttonAfisareMasini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmatransporturiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firmatransporturiDataSet
            // 
            this.firmatransporturiDataSet.DataSetName = "firmatransporturiDataSet";
            this.firmatransporturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soferiBindingSource
            // 
            this.soferiBindingSource.DataMember = "soferi";
            this.soferiBindingSource.DataSource = this.firmatransporturiDataSet;
            // 
            // soferiTableAdapter
            // 
            this.soferiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soferiToolStripMenuItem,
            this.masiniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soferiToolStripMenuItem
            // 
            this.soferiToolStripMenuItem.Name = "soferiToolStripMenuItem";
            this.soferiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.soferiToolStripMenuItem.Text = "Soferi";
            this.soferiToolStripMenuItem.Click += new System.EventHandler(this.soferiToolStripMenuItem_Click);
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.masiniToolStripMenuItem.Text = "Masini";
            this.masiniToolStripMenuItem.Click += new System.EventHandler(this.masiniToolStripMenuItem_Click);
            // 
            // listViewTransporturi
            // 
            this.listViewTransporturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderPlecare,
            this.columnHeaderSosire,
            this.columnHeaderDistanta,
            this.columnHeaderCantitate,
            this.columnHeaderNrInmatriculare,
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderCNP});
            this.listViewTransporturi.FullRowSelect = true;
            this.listViewTransporturi.HideSelection = false;
            this.listViewTransporturi.Location = new System.Drawing.Point(12, 27);
            this.listViewTransporturi.Name = "listViewTransporturi";
            this.listViewTransporturi.Size = new System.Drawing.Size(1084, 478);
            this.listViewTransporturi.TabIndex = 1;
            this.listViewTransporturi.UseCompatibleStateImageBehavior = false;
            this.listViewTransporturi.View = System.Windows.Forms.View.Details;
            this.listViewTransporturi.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTransporturi_ItemDrag);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 25;
            // 
            // columnHeaderPlecare
            // 
            this.columnHeaderPlecare.Text = "Oras Plecare";
            this.columnHeaderPlecare.Width = 81;
            // 
            // columnHeaderSosire
            // 
            this.columnHeaderSosire.Text = "Oras Sosire";
            this.columnHeaderSosire.Width = 78;
            // 
            // columnHeaderDistanta
            // 
            this.columnHeaderDistanta.Text = "Distanta (km)";
            this.columnHeaderDistanta.Width = 85;
            // 
            // columnHeaderCantitate
            // 
            this.columnHeaderCantitate.Text = "Cantitate (tone)";
            this.columnHeaderCantitate.Width = 92;
            // 
            // columnHeaderNrInmatriculare
            // 
            this.columnHeaderNrInmatriculare.Text = "Numar Inmatriculare";
            this.columnHeaderNrInmatriculare.Width = 110;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume Sofer";
            this.columnHeaderNume.Width = 99;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "PrenumeSofer";
            this.columnHeaderPrenume.Width = 166;
            // 
            // columnHeaderCNP
            // 
            this.columnHeaderCNP.Text = "CNP Sofer";
            this.columnHeaderCNP.Width = 151;
            // 
            // buttonAdaugaTransport
            // 
            this.buttonAdaugaTransport.Location = new System.Drawing.Point(307, 511);
            this.buttonAdaugaTransport.Name = "buttonAdaugaTransport";
            this.buttonAdaugaTransport.Size = new System.Drawing.Size(545, 52);
            this.buttonAdaugaTransport.TabIndex = 2;
            this.buttonAdaugaTransport.Text = "Adauga transport";
            this.buttonAdaugaTransport.UseVisualStyleBackColor = true;
            this.buttonAdaugaTransport.Click += new System.EventHandler(this.buttonAdaugaTransport_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1125, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stergere";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // buttonGrafic
            // 
            this.buttonGrafic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafic.Location = new System.Drawing.Point(1122, 53);
            this.buttonGrafic.Name = "buttonGrafic";
            this.buttonGrafic.Size = new System.Drawing.Size(165, 134);
            this.buttonGrafic.TabIndex = 4;
            this.buttonGrafic.Text = "Generare grafic categorii soferi";
            this.buttonGrafic.UseVisualStyleBackColor = true;
            this.buttonGrafic.Click += new System.EventHandler(this.buttonGrafic_Click);
            // 
            // buttonAfisareMasini
            // 
            this.buttonAfisareMasini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisareMasini.Location = new System.Drawing.Point(1132, 322);
            this.buttonAfisareMasini.Name = "buttonAfisareMasini";
            this.buttonAfisareMasini.Size = new System.Drawing.Size(155, 140);
            this.buttonAfisareMasini.TabIndex = 5;
            this.buttonAfisareMasini.Text = "Afisare masini in fisier text";
            this.buttonAfisareMasini.UseVisualStyleBackColor = true;
            this.buttonAfisareMasini.Click += new System.EventHandler(this.buttonAfisareMasini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 575);
            this.Controls.Add(this.buttonAfisareMasini);
            this.Controls.Add(this.buttonGrafic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdaugaTransport);
            this.Controls.Add(this.listViewTransporturi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmatransporturiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private firmatransporturiDataSet firmatransporturiDataSet;
        private System.Windows.Forms.BindingSource soferiBindingSource;
        private firmatransporturiDataSetTableAdapters.soferiTableAdapter soferiTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soferiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ListView listViewTransporturi;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderPlecare;
        private System.Windows.Forms.ColumnHeader columnHeaderSosire;
        private System.Windows.Forms.ColumnHeader columnHeaderDistanta;
        private System.Windows.Forms.ColumnHeader columnHeaderCantitate;
        private System.Windows.Forms.ColumnHeader columnHeaderNrInmatriculare;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderCNP;
        private System.Windows.Forms.Button buttonAdaugaTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGrafic;
        private System.Windows.Forms.Button buttonAfisareMasini;
    }
}

