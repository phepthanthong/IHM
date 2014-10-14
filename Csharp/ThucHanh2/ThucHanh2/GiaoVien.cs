using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            GiaovienInfo gv = new GiaovienInfo();
            try
            {
                gv.Maso = this.comboBoxMaso.Items[comboBoxMaso.SelectedIndex].ToString();
                gv.Hoten = this.textBoxHoten.Text.ToString();
                gv.Gt = true;
                gv.Mail = this.textBoxMail.Text.ToString();
                gv.Ngaysinh = this.dateTimePicker1.Value;
                if (rdNu.Checked)
                    gv.Gt = false;
                gv.SDT = maskedTextBoxDT.Text.ToString();

                List<string> ngoaingu = new List<string>();
                for (int i = 0; i<checkedListBoxNgoaingu.Items.Count; i++ )
                {
                    if (checkedListBoxNgoaingu.GetItemChecked(i))
                        ngoaingu.Add(checkedListBoxNgoaingu.Items[i].ToString());
                }
                gv.NgoaiNgu = ngoaingu;

                List<string> monhoc = new List<string>();
                foreach (var item in listBoxGiangday.Items)
                {
                    monhoc.Add(item.ToString());
                }
                gv.MonHoc = monhoc;

                FormThongtin form = new FormThongtin();
                form.ShowThongtin(gv.ToString());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int select = this.listBoxMonhoc.SelectedItems.Count-1;
            while (select >= 0)
            {
                this.listBoxGiangday.Items.Add(listBoxMonhoc.SelectedItems[select].ToString());
                listBoxMonhoc.Items.Remove(listBoxMonhoc.SelectedItems[select]);
                select--;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int select = this.listBoxGiangday.SelectedItems.Count - 1;
            while (select >= 0)
            {
                this.listBoxMonhoc.Items.Add(listBoxGiangday.SelectedItems[select].ToString());
                listBoxGiangday.Items.Remove(listBoxGiangday.SelectedItems[select]);
                select--;
            }
        }

        private void labelCancel_Click(object sender, EventArgs e)
        {
            this.comboBoxMaso.SelectedIndex = 0;
            this.textBoxHoten.Text = "";
            this.textBoxMail.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            if (rdNu.Checked)
            {
                rdNu.Checked = false;
                rdNam.Checked = true;
            }
            for (int i = 0; i < checkedListBoxNgoaingu.Items.Count; i++)
            {
                if (checkedListBoxNgoaingu.GetItemChecked(i))
                    checkedListBoxNgoaingu.SetItemChecked(i, false);
            }
            foreach (var item in listBoxGiangday.Items)
            {
                this.listBoxMonhoc.Items.Add(item);
            }
            listBoxGiangday.Items.Clear();
        }

        
        
    }
}
