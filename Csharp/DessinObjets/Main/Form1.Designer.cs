namespace Main
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
            this.dessinObjets1 = new DessinObjets.DessinObjets();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Epaisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Couleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dessinObjets1
            // 
            this.dessinObjets1.AutoSize = true;
            this.dessinObjets1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dessinObjets1.CouleurParDéfaut = System.Drawing.Color.Black;
            this.dessinObjets1.EpaisseurParDéfaut = 1;
            this.dessinObjets1.Location = new System.Drawing.Point(-4, 0);
            this.dessinObjets1.Name = "dessinObjets1";
            this.dessinObjets1.Size = new System.Drawing.Size(477, 389);
            this.dessinObjets1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Epaisseur,
            this.Couleur,
            this.Position});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Location = new System.Drawing.Point(479, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 390);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 390);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dessinObjets1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DessinObjets.DessinObjets dessinObjets1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Epaisseur;
        private System.Windows.Forms.ColumnHeader Couleur;
        private System.Windows.Forms.ColumnHeader Position;
    }
}

