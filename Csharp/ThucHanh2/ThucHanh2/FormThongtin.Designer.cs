namespace ThucHanh2
{
    partial class FormThongtin
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
            this.labelThongtin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThongtin
            // 
            this.labelThongtin.AutoSize = true;
            this.labelThongtin.Location = new System.Drawing.Point(46, 26);
            this.labelThongtin.Name = "labelThongtin";
            this.labelThongtin.Size = new System.Drawing.Size(35, 13);
            this.labelThongtin.TabIndex = 0;
            this.labelThongtin.Text = "label1";
            // 
            // FormThongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 305);
            this.Controls.Add(this.labelThongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThongtin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongtin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThongtin;
    }
}