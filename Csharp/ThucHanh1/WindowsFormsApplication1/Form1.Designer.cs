namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbomaso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTinhocA = new System.Windows.Forms.CheckBox();
            this.labelTinhocA = new System.Windows.Forms.Label();
            this.checkBoxTinhocB = new System.Windows.Forms.CheckBox();
            this.labelTinhocB = new System.Windows.Forms.Label();
            this.checkBoxTienganhA = new System.Windows.Forms.CheckBox();
            this.labelTienganhA = new System.Windows.Forms.Label();
            this.checkBoxTienganhB = new System.Windows.Forms.CheckBox();
            this.labelTienganhB = new System.Windows.Forms.Label();
            this.labelTongtien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.buttonThanhtoan = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TIỀN HỌC PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số";
            // 
            // cbomaso
            // 
            this.cbomaso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaso.FormattingEnabled = true;
            this.cbomaso.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cbomaso.Location = new System.Drawing.Point(88, 63);
            this.cbomaso.Name = "cbomaso";
            this.cbomaso.Size = new System.Drawing.Size(89, 21);
            this.cbomaso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(290, 67);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(381, 67);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(88, 105);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(249, 20);
            this.txtHoten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày đăng kí";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // checkBoxTinhocA
            // 
            this.checkBoxTinhocA.AutoSize = true;
            this.checkBoxTinhocA.Location = new System.Drawing.Point(88, 198);
            this.checkBoxTinhocA.Name = "checkBoxTinhocA";
            this.checkBoxTinhocA.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTinhocA.TabIndex = 7;
            this.checkBoxTinhocA.Text = "Tin học A";
            this.checkBoxTinhocA.UseVisualStyleBackColor = true;
            // 
            // labelTinhocA
            // 
            this.labelTinhocA.AutoSize = true;
            this.labelTinhocA.Location = new System.Drawing.Point(290, 198);
            this.labelTinhocA.Name = "labelTinhocA";
            this.labelTinhocA.Size = new System.Drawing.Size(72, 13);
            this.labelTinhocA.TabIndex = 8;
            this.labelTinhocA.Text = "300.000 VND";
            // 
            // checkBoxTinhocB
            // 
            this.checkBoxTinhocB.AutoSize = true;
            this.checkBoxTinhocB.Location = new System.Drawing.Point(88, 221);
            this.checkBoxTinhocB.Name = "checkBoxTinhocB";
            this.checkBoxTinhocB.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTinhocB.TabIndex = 7;
            this.checkBoxTinhocB.Text = "Tin học B";
            this.checkBoxTinhocB.UseVisualStyleBackColor = true;
            // 
            // labelTinhocB
            // 
            this.labelTinhocB.AutoSize = true;
            this.labelTinhocB.Location = new System.Drawing.Point(290, 221);
            this.labelTinhocB.Name = "labelTinhocB";
            this.labelTinhocB.Size = new System.Drawing.Size(72, 13);
            this.labelTinhocB.TabIndex = 8;
            this.labelTinhocB.Text = "500.000 VND";
            // 
            // checkBoxTienganhA
            // 
            this.checkBoxTienganhA.AutoSize = true;
            this.checkBoxTienganhA.Location = new System.Drawing.Point(88, 244);
            this.checkBoxTienganhA.Name = "checkBoxTienganhA";
            this.checkBoxTienganhA.Size = new System.Drawing.Size(85, 17);
            this.checkBoxTienganhA.TabIndex = 7;
            this.checkBoxTienganhA.Text = "Tiếng Anh A";
            this.checkBoxTienganhA.UseVisualStyleBackColor = true;
            // 
            // labelTienganhA
            // 
            this.labelTienganhA.AutoSize = true;
            this.labelTienganhA.Location = new System.Drawing.Point(290, 244);
            this.labelTienganhA.Name = "labelTienganhA";
            this.labelTienganhA.Size = new System.Drawing.Size(72, 13);
            this.labelTienganhA.TabIndex = 8;
            this.labelTienganhA.Text = "400.000 VND";
            // 
            // checkBoxTienganhB
            // 
            this.checkBoxTienganhB.AutoSize = true;
            this.checkBoxTienganhB.Location = new System.Drawing.Point(88, 267);
            this.checkBoxTienganhB.Name = "checkBoxTienganhB";
            this.checkBoxTienganhB.Size = new System.Drawing.Size(85, 17);
            this.checkBoxTienganhB.TabIndex = 7;
            this.checkBoxTienganhB.Text = "Tiếng Anh B";
            this.checkBoxTienganhB.UseVisualStyleBackColor = true;
            // 
            // labelTienganhB
            // 
            this.labelTienganhB.AutoSize = true;
            this.labelTienganhB.Location = new System.Drawing.Point(290, 267);
            this.labelTienganhB.Name = "labelTienganhB";
            this.labelTienganhB.Size = new System.Drawing.Size(72, 13);
            this.labelTienganhB.TabIndex = 8;
            this.labelTienganhB.Text = "600.000 VND";
            // 
            // labelTongtien
            // 
            this.labelTongtien.AutoSize = true;
            this.labelTongtien.Location = new System.Drawing.Point(138, 322);
            this.labelTongtien.Name = "labelTongtien";
            this.labelTongtien.Size = new System.Drawing.Size(120, 13);
            this.labelTongtien.TabIndex = 4;
            this.labelTongtien.Text = "Tổng số tiền thanh toán";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Location = new System.Drawing.Point(264, 319);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(156, 20);
            this.txtTongtien.TabIndex = 5;
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.Location = new System.Drawing.Point(39, 398);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(75, 23);
            this.buttonThanhtoan.TabIndex = 9;
            this.buttonThanhtoan.Text = "Thanh toán";
            this.buttonThanhtoan.UseVisualStyleBackColor = true;
            this.buttonThanhtoan.Click += new System.EventHandler(this.buttonThanhtoan_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(191, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(345, 398);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 469);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonThanhtoan);
            this.Controls.Add(this.labelTienganhB);
            this.Controls.Add(this.labelTienganhA);
            this.Controls.Add(this.labelTinhocB);
            this.Controls.Add(this.labelTinhocA);
            this.Controls.Add(this.checkBoxTienganhB);
            this.Controls.Add(this.checkBoxTienganhA);
            this.Controls.Add(this.checkBoxTinhocB);
            this.Controls.Add(this.checkBoxTinhocA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cbomaso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền học phí";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomaso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxTinhocA;
        private System.Windows.Forms.Label labelTinhocA;
        private System.Windows.Forms.CheckBox checkBoxTinhocB;
        private System.Windows.Forms.Label labelTinhocB;
        private System.Windows.Forms.CheckBox checkBoxTienganhA;
        private System.Windows.Forms.Label labelTienganhA;
        private System.Windows.Forms.CheckBox checkBoxTienganhB;
        private System.Windows.Forms.Label labelTienganhB;
        private System.Windows.Forms.Label labelTongtien;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button buttonThanhtoan;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}

