namespace projet3
{
    partial class Form9
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
            this.ouvrirSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unFourniseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMeubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unMeubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fICHIERToolStripMenuItem
            // 
            this.fICHIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirSessionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fICHIERToolStripMenuItem.Name = "fICHIERToolStripMenuItem";
            this.fICHIERToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fICHIERToolStripMenuItem.Text = "FICHIER";
            // 
            // ouvrirSessionToolStripMenuItem
            // 
            this.ouvrirSessionToolStripMenuItem.Name = "ouvrirSessionToolStripMenuItem";
            this.ouvrirSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirSessionToolStripMenuItem.Text = "Ouvrir session";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unFourniseurToolStripMenuItem,
            this.ajouterUnClientToolStripMenuItem,
            this.ajouterUnMeubleToolStripMenuItem});
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // unFourniseurToolStripMenuItem
            // 
            this.unFourniseurToolStripMenuItem.Name = "unFourniseurToolStripMenuItem";
            this.unFourniseurToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unFourniseurToolStripMenuItem.Text = "Ajouterun Fourniseur";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un Client";
            // 
            // ajouterUnMeubleToolStripMenuItem
            // 
            this.ajouterUnMeubleToolStripMenuItem.Name = "ajouterUnMeubleToolStripMenuItem";
            this.ajouterUnMeubleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ajouterUnMeubleToolStripMenuItem.Text = "Ajouter un Meuble";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unMeubleToolStripMenuItem});
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consulterToolStripMenuItem.Text = "Consulter";
            // 
            // unMeubleToolStripMenuItem
            // 
            this.unMeubleToolStripMenuItem.Name = "unMeubleToolStripMenuItem";
            this.unMeubleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unMeubleToolStripMenuItem.Text = "un Meuble";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet3.Properties.Resources._00011;
            this.ClientSize = new System.Drawing.Size(1125, 746);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fICHIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unFourniseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMeubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMeubleToolStripMenuItem;
    }
}