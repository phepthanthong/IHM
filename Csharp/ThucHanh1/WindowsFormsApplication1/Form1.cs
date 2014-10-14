using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTongtien.Text = "0";
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            //string tongtien = ""; 
            double tongtien = 0;
            if (checkBoxTinhocA.Checked)
                tongtien += double.Parse(this.labelTinhocA.Text.Split(' ')[0]);
            if (checkBoxTinhocB.Checked)
                tongtien += double.Parse(this.labelTinhocB.Text.Split(' ')[0]);
            if (checkBoxTienganhA.Checked)
                tongtien += double.Parse(this.labelTienganhA.Text.Split(' ')[0]);
            if (checkBoxTienganhB.Checked)
                tongtien += double.Parse(this.labelTienganhB.Text.Split(' ')[0]);
            txtTongtien.Text = tongtien.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.cbomaso.Text = this.cbomaso.Items[0].ToString();
            if (rdNu.Checked)
            {
                rdNu.Checked = false;
                rdNam.Checked = true;
            }
            this.txtHoten.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            if (checkBoxTienganhA.Checked)
                this.checkBoxTienganhA.Checked = false;
            if (checkBoxTienganhB.Checked)
                this.checkBoxTienganhB.Checked = false;
            if (checkBoxTinhocA.Checked)
                this.checkBoxTinhocA.Checked = false;
            if (checkBoxTinhocB.Checked)
                this.checkBoxTinhocB.Checked = false;
            this.txtTongtien.Text = "";

        }
    }
}
