namespace ProjetDamier
{
    partial class FenetreDamier
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
            this.SuspendLayout();
            // 
            // FenetreDamier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.DoubleBuffered = true;
            this.Name = "FenetreDamier";
            this.Text = "Construction d\'un Damier";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FenetreDamier_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FenetreDamier_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

