namespace ThucHanh2
{
    partial class GiaoVien
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
            this.labelMaso = new System.Windows.Forms.Label();
            this.comboBoxMaso = new System.Windows.Forms.ComboBox();
            this.labelGioitinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.labelHoten = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelNgaysinh = new System.Windows.Forms.Label();
            this.textBoxHoten = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNgoaingu = new System.Windows.Forms.Label();
            this.checkedListBoxNgoaingu = new System.Windows.Forms.CheckedListBox();
            this.listBoxMonhoc = new System.Windows.Forms.ListBox();
            this.labelDanhsachmon = new System.Windows.Forms.Label();
            this.linkLienhe = new System.Windows.Forms.LinkLabel();
            this.maskedTextBoxDT = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxGiangday = new System.Windows.Forms.ListBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.labelCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDanhsachday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThongtin
            // 
            this.labelThongtin.AutoSize = true;
            this.labelThongtin.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongtin.Location = new System.Drawing.Point(156, 9);
            this.labelThongtin.Name = "labelThongtin";
            this.labelThongtin.Size = new System.Drawing.Size(276, 18);
            this.labelThongtin.TabIndex = 0;
            this.labelThongtin.Text = "Thông tin giáo viên khoa CNTT";
            // 
            // labelMaso
            // 
            this.labelMaso.AutoSize = true;
            this.labelMaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaso.Location = new System.Drawing.Point(48, 52);
            this.labelMaso.Name = "labelMaso";
            this.labelMaso.Size = new System.Drawing.Size(41, 13);
            this.labelMaso.TabIndex = 1;
            this.labelMaso.Text = "Mã số";
            // 
            // comboBoxMaso
            // 
            this.comboBoxMaso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaso.FormattingEnabled = true;
            this.comboBoxMaso.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.comboBoxMaso.Location = new System.Drawing.Point(117, 49);
            this.comboBoxMaso.Name = "comboBoxMaso";
            this.comboBoxMaso.Size = new System.Drawing.Size(102, 21);
            this.comboBoxMaso.TabIndex = 2;
            // 
            // labelGioitinh
            // 
            this.labelGioitinh.AutoSize = true;
            this.labelGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGioitinh.Location = new System.Drawing.Point(300, 52);
            this.labelGioitinh.Name = "labelGioitinh";
            this.labelGioitinh.Size = new System.Drawing.Size(56, 13);
            this.labelGioitinh.TabIndex = 1;
            this.labelGioitinh.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(385, 50);
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
            this.rdNu.Location = new System.Drawing.Point(468, 50);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // labelHoten
            // 
            this.labelHoten.AutoSize = true;
            this.labelHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHoten.Location = new System.Drawing.Point(48, 87);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(45, 13);
            this.labelHoten.TabIndex = 1;
            this.labelHoten.Text = "Họ tên";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEmail.Location = new System.Drawing.Point(300, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Địa chỉ mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(376, 128);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(188, 20);
            this.textBoxMail.TabIndex = 4;
            // 
            // labelNgaysinh
            // 
            this.labelNgaysinh.AutoSize = true;
            this.labelNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNgaysinh.Location = new System.Drawing.Point(48, 131);
            this.labelNgaysinh.Name = "labelNgaysinh";
            this.labelNgaysinh.Size = new System.Drawing.Size(63, 13);
            this.labelNgaysinh.TabIndex = 1;
            this.labelNgaysinh.Text = "Ngày sinh";
            // 
            // textBoxHoten
            // 
            this.textBoxHoten.Location = new System.Drawing.Point(117, 84);
            this.textBoxHoten.Name = "textBoxHoten";
            this.textBoxHoten.Size = new System.Drawing.Size(131, 20);
            this.textBoxHoten.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(300, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số ĐT";
            // 
            // labelNgoaingu
            // 
            this.labelNgoaingu.AutoSize = true;
            this.labelNgoaingu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNgoaingu.Location = new System.Drawing.Point(48, 172);
            this.labelNgoaingu.Name = "labelNgoaingu";
            this.labelNgoaingu.Size = new System.Drawing.Size(65, 13);
            this.labelNgoaingu.TabIndex = 1;
            this.labelNgoaingu.Text = "Ngoại ngữ";
            // 
            // checkedListBoxNgoaingu
            // 
            this.checkedListBoxNgoaingu.FormattingEnabled = true;
            this.checkedListBoxNgoaingu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.checkedListBoxNgoaingu.Location = new System.Drawing.Point(117, 172);
            this.checkedListBoxNgoaingu.Name = "checkedListBoxNgoaingu";
            this.checkedListBoxNgoaingu.Size = new System.Drawing.Size(91, 64);
            this.checkedListBoxNgoaingu.TabIndex = 6;
            // 
            // listBoxMonhoc
            // 
            this.listBoxMonhoc.FormattingEnabled = true;
            this.listBoxMonhoc.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình C/C++",
            "Cơ sở dữ liệu",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Lập trình hướng sự kiện",
            "Thiết kế hệ thống",
            "Tiếng Anh",
            "Tiếng Pháp"});
            this.listBoxMonhoc.Location = new System.Drawing.Point(112, 281);
            this.listBoxMonhoc.Name = "listBoxMonhoc";
            this.listBoxMonhoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMonhoc.Size = new System.Drawing.Size(151, 108);
            this.listBoxMonhoc.TabIndex = 7;
            // 
            // labelDanhsachmon
            // 
            this.labelDanhsachmon.AutoSize = true;
            this.labelDanhsachmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDanhsachmon.Location = new System.Drawing.Point(109, 254);
            this.labelDanhsachmon.Name = "labelDanhsachmon";
            this.labelDanhsachmon.Size = new System.Drawing.Size(120, 13);
            this.labelDanhsachmon.TabIndex = 8;
            this.labelDanhsachmon.Text = "Danh sách môn học";
            // 
            // linkLienhe
            // 
            this.linkLienhe.AutoSize = true;
            this.linkLienhe.Location = new System.Drawing.Point(532, 483);
            this.linkLienhe.Name = "linkLienhe";
            this.linkLienhe.Size = new System.Drawing.Size(42, 13);
            this.linkLienhe.TabIndex = 9;
            this.linkLienhe.TabStop = true;
            this.linkLienhe.Text = "Liên hệ";
            // 
            // maskedTextBoxDT
            // 
            this.maskedTextBoxDT.Location = new System.Drawing.Point(376, 84);
            this.maskedTextBoxDT.Mask = "(\\063).000.000";
            this.maskedTextBoxDT.Name = "maskedTextBoxDT";
            this.maskedTextBoxDT.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBoxDT.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(303, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(303, 346);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(40, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "<<";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxGiangday
            // 
            this.listBoxGiangday.FormattingEnabled = true;
            this.listBoxGiangday.Location = new System.Drawing.Point(376, 281);
            this.listBoxGiangday.Name = "listBoxGiangday";
            this.listBoxGiangday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGiangday.Size = new System.Drawing.Size(153, 108);
            this.listBoxGiangday.TabIndex = 13;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(112, 443);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 14;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // labelCancel
            // 
            this.labelCancel.Location = new System.Drawing.Point(255, 443);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(75, 23);
            this.labelCancel.TabIndex = 14;
            this.labelCancel.Text = "Cancel";
            this.labelCancel.UseVisualStyleBackColor = true;
            this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(407, 443);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDanhsachday
            // 
            this.labelDanhsachday.AutoSize = true;
            this.labelDanhsachday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDanhsachday.Location = new System.Drawing.Point(373, 254);
            this.labelDanhsachday.Name = "labelDanhsachday";
            this.labelDanhsachday.Size = new System.Drawing.Size(115, 13);
            this.labelDanhsachday.TabIndex = 8;
            this.labelDanhsachday.Text = "Môn học giảng dạy";
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 516);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.listBoxGiangday);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxDT);
            this.Controls.Add(this.linkLienhe);
            this.Controls.Add(this.labelDanhsachday);
            this.Controls.Add(this.labelDanhsachmon);
            this.Controls.Add(this.listBoxMonhoc);
            this.Controls.Add(this.checkedListBoxNgoaingu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxHoten);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.comboBoxMaso);
            this.Controls.Add(this.labelGioitinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNgoaingu);
            this.Controls.Add(this.labelNgaysinh);
            this.Controls.Add(this.labelHoten);
            this.Controls.Add(this.labelMaso);
            this.Controls.Add(this.labelThongtin);
            this.Name = "GiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThongtin;
        private System.Windows.Forms.Label labelMaso;
        private System.Windows.Forms.ComboBox comboBoxMaso;
        private System.Windows.Forms.Label labelGioitinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelNgaysinh;
        private System.Windows.Forms.TextBox textBoxHoten;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNgoaingu;
        private System.Windows.Forms.CheckedListBox checkedListBoxNgoaingu;
        private System.Windows.Forms.ListBox listBoxMonhoc;
        private System.Windows.Forms.Label labelDanhsachmon;
        private System.Windows.Forms.LinkLabel linkLienhe;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDT;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxGiangday;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button labelCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDanhsachday;
    }
}

