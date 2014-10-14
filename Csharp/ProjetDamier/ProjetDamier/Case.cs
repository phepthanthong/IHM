using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetDamier
{
    public class Case
    {
        #region atributs
        private Rectangle rect;
        bool check;
        //private Rectangle pion;
        //private Color couleurFond;
        private Point point;
        #endregion attributs

        private void Init()
        {
            rect = new Rectangle(200,200,100,100);
            //pion = new Rectangle(200, 200, 100, 100);
        }

        public Case(Rectangle r, Rectangle cer, Color c)
        {
            rect = r;
            //pion = cer;
            //couleurFond = c;
        }

        public Case(Point p,bool hieu)
        {
            check = hieu;
            this.point = p;
            rect = new Rectangle(p.X-50,p.Y-50, 100, 100);
            //this.pion = cer;
        }

        public void Dessine(Graphics g)
        {
            if(check)
                g.FillRectangle(Brushes.Black, rect);
            //else {g.FillRectangle(Brushes.Black, rect);
               // g.FillEllipse(Brushes.White,rect);
           // }
        }
        public bool Contains(Point p)
        {
            return rect.Contains(p);
        }
                
    }
}
