namespace Notebook
{
    partial class frmNotatnik
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MNowy = new System.Windows.Forms.ToolStripMenuItem();
            this.MOtworz = new System.Windows.Forms.ToolStripMenuItem();
            this.MSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtTresc = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(293, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNowy,
            this.MOtworz,
            this.MSave,
            this.MSaveAs});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // MNowy
            // 
            this.MNowy.Name = "MNowy";
            this.MNowy.Size = new System.Drawing.Size(180, 22);
            this.MNowy.Text = "New";
            this.MNowy.Click += new System.EventHandler(this.MNowy_Click);
            // 
            // MOtworz
            // 
            this.MOtworz.Name = "MOtworz";
            this.MOtworz.Size = new System.Drawing.Size(180, 22);
            this.MOtworz.Text = "Open";
            this.MOtworz.Click += new System.EventHandler(this.MOpen_Click);
            // 
            // MSave
            // 
            this.MSave.Name = "MSave";
            this.MSave.Size = new System.Drawing.Size(180, 22);
            this.MSave.Text = "Save";
            this.MSave.Click += new System.EventHandler(this.MSave_Click);
            // 
            // MSaveAs
            // 
            this.MSaveAs.Name = "MSaveAs";
            this.MSaveAs.Size = new System.Drawing.Size(180, 22);
            this.MSaveAs.Text = "Save as";
            this.MSaveAs.Click += new System.EventHandler(this.MSaveAs_Click);
            // 
            // TxtTresc
            // 
            this.TxtTresc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTresc.Location = new System.Drawing.Point(0, 24);
            this.TxtTresc.Multiline = true;
            this.TxtTresc.Name = "TxtTresc";
            this.TxtTresc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTresc.Size = new System.Drawing.Size(292, 273);
            this.TxtTresc.TabIndex = 1;
            // 
            // frmNotatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.TxtTresc);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmNotatnik";
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotatnik_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MNowy;
        private System.Windows.Forms.ToolStripMenuItem MOtworz;
        private System.Windows.Forms.ToolStripMenuItem MSave;
        private System.Windows.Forms.ToolStripMenuItem MSaveAs;
        private System.Windows.Forms.TextBox TxtTresc;
    }
}

