using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessinObjets
{
    public partial class BoiteDialogGenerique : Form
    {
        Object m_ob;
        int x = 10; int y = 10;

        public BoiteDialogGenerique(Object ob)
        {
            InitializeComponent();
            PropertyInfo[] properties = ob.GetType().GetProperties();
            foreach (PropertyInfo p in properties)
            {
                if (p.SetMethod == null)
                    break;


                Label lb = new Label();
                lb.Text = p.Name;
                lb.Location = new Point(x, y);
                Controls.Add(lb);

                Control tb = new TextBox();
                tb.Location = new Point(x + lb.Width + 5, y);
                Controls.Add(tb);

                tb.Tag = p;

                if (p.GetValue(ob) != null)
                    tb.Text = p.GetValue(ob).ToString();

                y = y + tb.Height + 10;

                //string[] texte_Boutons = new string[] { "OK", "Annuler" };
                //foreach (string s in texte_Boutons)
                //{
                //    Button bouton = new Button();
                //    bouton.Text = s;
                //    Controls.Add(bouton);
                //    bouton.Location = new Point(x, y);
                //    bouton.Click += butOK.Click;
                //    y += bouton.Height + 5;
                //}
            }
        }
    }
}
