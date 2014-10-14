namespace ProjetSudoku
{
    partial class Sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUneGrilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNum1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDessin = new System.Windows.Forms.Panel();
            this.pageAccueil = new System.Windows.Forms.Panel();
            this.richtxtManuel = new System.Windows.Forms.RichTextBox();
            this.butInstruction = new System.Windows.Forms.Button();
            this.butJouer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butPageAccueil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pageAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUneGrilleToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // ouvrirUneGrilleToolStripMenuItem
            // 
            this.ouvrirUneGrilleToolStripMenuItem.Name = "ouvrirUneGrilleToolStripMenuItem";
            this.ouvrirUneGrilleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ouvrirUneGrilleToolStripMenuItem.Text = "Ouvrir  une grille";
            this.ouvrirUneGrilleToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUneGrilleToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNum1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // buttonNum1
            // 
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(80, 22);
            this.buttonNum1.Text = "1";
            this.buttonNum1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panelDessin
            // 
            this.panelDessin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDessin.ForeColor = System.Drawing.SystemColors.Control;
            this.panelDessin.Location = new System.Drawing.Point(145, 60);
            this.panelDessin.Name = "panelDessin";
            this.panelDessin.Size = new System.Drawing.Size(330, 330);
            this.panelDessin.TabIndex = 1;
            this.panelDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDessin_Paint);
            // 
            // pageAccueil
            // 
            this.pageAccueil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageAccueil.Controls.Add(this.richtxtManuel);
            this.pageAccueil.Controls.Add(this.butInstruction);
            this.pageAccueil.Controls.Add(this.butJouer);
            this.pageAccueil.Controls.Add(this.label2);
            this.pageAccueil.Controls.Add(this.label1);
            this.pageAccueil.Location = new System.Drawing.Point(0, 27);
            this.pageAccueil.Name = "pageAccueil";
            this.pageAccueil.Size = new System.Drawing.Size(614, 412);
            this.pageAccueil.TabIndex = 2;
            // 
            // richtxtManuel
            // 
            this.richtxtManuel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richtxtManuel.Location = new System.Drawing.Point(145, 78);
            this.richtxtManuel.Name = "richtxtManuel";
            this.richtxtManuel.ReadOnly = true;
            this.richtxtManuel.Size = new System.Drawing.Size(327, 170);
            this.richtxtManuel.TabIndex = 2;
            this.richtxtManuel.Text = "\t\tManuel Utilisateur\n\nBienvenue à vous !\n\nPour jouer, appuyez sur \"Play\".\n\nPuis, " +
    "allez sur la barre menu et choisissez Jeu, \"Ouvrir une grille\" \n\nEt enfin, bonne" +
    " chance !";
            this.richtxtManuel.Visible = false;
            // 
            // butInstruction
            // 
            this.butInstruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInstruction.BackgroundImage")));
            this.butInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInstruction.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInstruction.Location = new System.Drawing.Point(252, 153);
            this.butInstruction.Name = "butInstruction";
            this.butInstruction.Size = new System.Drawing.Size(99, 35);
            this.butInstruction.TabIndex = 1;
            this.butInstruction.UseVisualStyleBackColor = true;
            this.butInstruction.Click += new System.EventHandler(this.butInstruction_Click);
            // 
            // butJouer
            // 
            this.butJouer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butJouer.BackgroundImage")));
            this.butJouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butJouer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butJouer.Location = new System.Drawing.Point(252, 280);
            this.butJouer.Name = "butJouer";
            this.butJouer.Size = new System.Drawing.Size(99, 35);
            this.butJouer.TabIndex = 1;
            this.butJouer.UseVisualStyleBackColor = true;
            this.butJouer.Click += new System.EventHandler(this.butJouer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Auteur: MAI Trung Hieu - LINF13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue au Jeu Sudoku";
            // 
            // butPageAccueil
            // 
            this.butPageAccueil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPageAccueil.Location = new System.Drawing.Point(252, 406);
            this.butPageAccueil.Name = "butPageAccueil";
            this.butPageAccueil.Size = new System.Drawing.Size(105, 23);
            this.butPageAccueil.TabIndex = 3;
            this.butPageAccueil.Text = "Page d\'Accueil";
            this.butPageAccueil.UseVisualStyleBackColor = true;
            this.butPageAccueil.Visible = false;
            this.butPageAccueil.Click += new System.EventHandler(this.butPageAccueil_Click);
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(614, 438);
            this.Controls.Add(this.butPageAccueil);
            this.Controls.Add(this.pageAccueil);
            this.Controls.Add(this.panelDessin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pageAccueil.ResumeLayout(false);
            this.pageAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUneGrilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Panel panelDessin;
        private System.Windows.Forms.ToolStripMenuItem buttonNum1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.Panel pageAccueil;
        private System.Windows.Forms.Button butJouer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butInstruction;
        private System.Windows.Forms.RichTextBox richtxtManuel;
        private System.Windows.Forms.Button butPageAccueil;
    }
}

