using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDamier
{
    public partial class FenetreDamier : Form
    {
        #region attributs
        Rectangle rectangle;
        bool hieu;
        Rectangle cercle;
        List<Case> damier = new List<Case>();
        Case damierCourant = null;
        #endregion attributs
        public FenetreDamier()
        {
            InitializeComponent();
            //Init();
        }

        private void Init()
        {
            rectangle = new Rectangle(50, 50, 100, 100);
            cercle = new Rectangle(50, 50, 100, 100);
        }

        private void FenetreDamier_Paint(object sender, PaintEventArgs e)
        {
            foreach (Case s in damier)
                s.Dessine(e.Graphics);
            Refresh();

            /*e.Graphics.DrawRectangle(Pens.Black, rectangle);
            e.Graphics.FillRectangle(Brushes.Black, rectangle);
            e.Graphics.DrawRectangle(Pens.Black, cercle);
            e.Graphics.FillEllipse(Brushes.White, cercle);*/
        }

        private void FenetreDamier_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    {
                        hieu = true;
                        break;
                    }
                case System.Windows.Forms.MouseButtons.Left:
                    {
                        hieu = false;
                        break;
                    }
            }
            Case cases = new Case(e.Location, hieu);
            damier.Add(cases);
            Refresh();
                
        }

        /*public Case DamierCourant(MouseEventArgs e)
        {
            foreach (Case ca in damier)
            {
                if (ca.Contains(e.Location))
                    return ca;
            }
            return null;
        }*/        

             
    }
}
