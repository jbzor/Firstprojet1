namespace projet3
{
    partial class Form8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fICHIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unMeubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesMeublesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meilleurFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fICHIERToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fICHIERToolStripMenuItem
            // 
            this.fICHIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fICHIERToolStripMenuItem.Name = "fICHIERToolStripMenuItem";
            this.fICHIERToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fICHIERToolStripMenuItem.Text = "FICHIER";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fournisseurToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.unMeubleToolStripMenuItem});
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fournisseurToolStripMenuItem.Text = "fournisseur";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clientToolStripMenuItem.Text = "client";
            // 
            // unMeubleToolStripMenuItem
            // 
            this.unMeubleToolStripMenuItem.Name = "unMeubleToolStripMenuItem";
            this.unMeubleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.unMeubleToolStripMenuItem.Text = "un Meuble";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesMeublesToolStripMenuItem,
            this.meilleurFournisseurToolStripMenuItem});
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.consulterToolStripMenuItem.Text = "consulter";
            // 
            // lesMeublesToolStripMenuItem
            // 
            this.lesMeublesToolStripMenuItem.Name = "lesMeublesToolStripMenuItem";
            this.lesMeublesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.lesMeublesToolStripMenuItem.Text = "les Meubles";
            // 
            // meilleurFournisseurToolStripMenuItem
            // 
            this.meilleurFournisseurToolStripMenuItem.Name = "meilleurFournisseurToolStripMenuItem";
            this.meilleurFournisseurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.meilleurFournisseurToolStripMenuItem.Text = "Meilleur fournisseur";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet3.Properties.Resources._00011;
            this.ClientSize = new System.Drawing.Size(1061, 749);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fICHIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMeubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesMeublesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meilleurFournisseurToolStripMenuItem;
    }
}