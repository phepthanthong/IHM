using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2
{
    class GiaovienInfo
    {
        public bool Gt { get; set; }
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Mail { get; set; }
        public string SDT { get; set; }
        public List<string> NgoaiNgu { get; set; }
        public List<string> MonHoc { get; set; }
        public override string ToString()
        {
            string s = "Ma So " + this.Maso + "\nHo ten " + this.Hoten + "\nGioi tinh " + this.Gt
                + "\nMail " + this.Mail + "\nSDT " + this.SDT + "\nNgay Sinh " + this.Ngaysinh
                + "\nNgoai ngu " + this.NgoaiNgu.ToString() + "\nMon giang day " + this.MonHoc.ToString();
            return s;
        }
    }
}
