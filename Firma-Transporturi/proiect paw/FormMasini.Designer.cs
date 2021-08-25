namespace proiect_paw
{
    partial class FormMasini
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
            this.listViewMasini = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrInmatriculare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCapacitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMeniuAdaugaMasini = new System.Windows.Forms.Button();
            this.contextMenuStripMasini = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMasini.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMasini
            // 
            this.listViewMasini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderNrInmatriculare,
            this.columnHeaderCapacitate,
            this.columnHeaderCategorie});
            this.listViewMasini.FullRowSelect = true;
            this.listViewMasini.HideSelection = false;
            this.listViewMasini.Location = new System.Drawing.Point(13, 13);
            this.listViewMasini.Name = "listViewMasini";
            this.listViewMasini.Size = new System.Drawing.Size(775, 331);
            this.listViewMasini.TabIndex = 0;
            this.listViewMasini.UseCompatibleStateImageBehavior = false;
            this.listViewMasini.View = System.Windows.Forms.View.Details;
            this.listViewMasini.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMasini_MouseClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderNrInmatriculare
            // 
            this.columnHeaderNrInmatriculare.Text = "Numar Inmatriculare";
            // 
            // columnHeaderCapacitate
            // 
            this.columnHeaderCapacitate.Text = "Capacitate (tone)";
            // 
            // columnHeaderCategorie
            // 
            this.columnHeaderCategorie.Text = "Categorie";
            // 
            // buttonMeniuAdaugaMasini
            // 
            this.buttonMeniuAdaugaMasini.Location = new System.Drawing.Point(217, 364);
            this.buttonMeniuAdaugaMasini.Name = "buttonMeniuAdaugaMasini";
            this.buttonMeniuAdaugaMasini.Size = new System.Drawing.Size(380, 74);
            this.buttonMeniuAdaugaMasini.TabIndex = 1;
            this.buttonMeniuAdaugaMasini.Text = "Adauga masina";
            this.buttonMeniuAdaugaMasini.UseVisualStyleBackColor = true;
            this.buttonMeniuAdaugaMasini.Click += new System.EventHandler(this.buttonMeniuAdaugaMasini_Click);
            // 
            // contextMenuStripMasini
            // 
            this.contextMenuStripMasini.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStripMasini.Name = "contextMenuStripMasini";
            this.contextMenuStripMasini.Size = new System.Drawing.Size(108, 26);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // FormMasini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMeniuAdaugaMasini);
            this.Controls.Add(this.listViewMasini);
            this.Name = "FormMasini";
            this.Text = "FormMasini";
            this.contextMenuStripMasini.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMasini;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderNrInmatriculare;
        private System.Windows.Forms.ColumnHeader columnHeaderCapacitate;
        private System.Windows.Forms.ColumnHeader columnHeaderCategorie;
        private System.Windows.Forms.Button buttonMeniuAdaugaMasini;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMasini;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}