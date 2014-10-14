using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DessinObjets;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DessinObjets_DrawnNode(object sender, NodeDrawnArg e)
        {
            Noeud n = e.noeud;

            ListViewItem it = new ListViewItem(n.Épaisseur.ToString());
            it.SubItems.Add(n.Couleur.ToString());
            it.SubItems.Add(n.Centre.ToString());
            listView1.Items.Add(it);

            Refresh();
        }
    }
}
