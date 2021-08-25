namespace proiect_paw
{
    partial class FormSoferi
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
            this.listViewSoferi = new System.Windows.Forms.ListView();
            this.ColoanaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColoanaNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColoanaPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColoanaCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColoanaPermis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdaugaSofer = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSoferi
            // 
            this.listViewSoferi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColoanaId,
            this.ColoanaNume,
            this.ColoanaPrenume,
            this.ColoanaCNP,
            this.ColoanaPermis});
            this.listViewSoferi.FullRowSelect = true;
            this.listViewSoferi.HideSelection = false;
            this.listViewSoferi.Location = new System.Drawing.Point(22, 13);
            this.listViewSoferi.Name = "listViewSoferi";
            this.listViewSoferi.Size = new System.Drawing.Size(757, 343);
            this.listViewSoferi.TabIndex = 0;
            this.listViewSoferi.UseCompatibleStateImageBehavior = false;
            this.listViewSoferi.View = System.Windows.Forms.View.Details;
            this.listViewSoferi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSoferi_MouseClick);
            // 
            // ColoanaId
            // 
            this.ColoanaId.Text = "ID";
            // 
            // ColoanaNume
            // 
            this.ColoanaNume.Text = "Nume";
            // 
            // ColoanaPrenume
            // 
            this.ColoanaPrenume.Text = "Prenume";
            // 
            // ColoanaCNP
            // 
            this.ColoanaCNP.Text = "CNP";
            // 
            // ColoanaPermis
            // 
            this.ColoanaPermis.Text = "Categorie permis";
            // 
            // buttonAdaugaSofer
            // 
            this.buttonAdaugaSofer.Location = new System.Drawing.Point(251, 362);
            this.buttonAdaugaSofer.Name = "buttonAdaugaSofer";
            this.buttonAdaugaSofer.Size = new System.Drawing.Size(321, 79);
            this.buttonAdaugaSofer.TabIndex = 1;
            this.buttonAdaugaSofer.Text = "Adauga Sofer";
            this.buttonAdaugaSofer.UseVisualStyleBackColor = true;
            this.buttonAdaugaSofer.Click += new System.EventHandler(this.buttonAdaugaSofer_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem,
            this.modificaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // FormSoferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdaugaSofer);
            this.Controls.Add(this.listViewSoferi);
            this.Name = "FormSoferi";
            this.Text = "FormSoferi";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdaugaSofer;
        private System.Windows.Forms.ColumnHeader ColoanaId;
        private System.Windows.Forms.ColumnHeader ColoanaNume;
        private System.Windows.Forms.ColumnHeader ColoanaPrenume;
        private System.Windows.Forms.ColumnHeader ColoanaCNP;
        private System.Windows.Forms.ColumnHeader ColoanaPermis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        public System.Windows.Forms.ListView listViewSoferi;
    }
}