using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dessin
{
    public partial class Dessin : Form
    {
        // Attributs
        // On peut préciser qu' un tel attribut est prive ou public.
        // Si on ne dit rien (comme ci-dessous), c'est prive.
        Point début;
        Point fin;
        Point deplace;
        Rectangle rectangle;
        Rectangle ellipse;
        String texte;
        //Constructeur
        public Dessin()
        {
            InitializeComponent();
            Init();
        }
        // methode pour initialiser les differents attributs
        private void Init()
        {
            ellipse = new Rectangle(200, 150, 50, 80);
            rectangle = new Rectangle(50, 50, 100, 100);
            début = new Point(10, 20);
            fin = new Point(200, 80);
            texte = "Bonjour";
            deplace = new Point(200, 80);
        }
        // methode pout affichage
        private void Dessin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Indigo, rectangle);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
            e.Graphics.FillEllipse(Brushes.Red, ellipse);
            e.Graphics.DrawLine(Pens.BlueViolet, début, fin);
            e.Graphics.DrawString(texte, new Font("Arial", 15), Brushes.Fuchsia, deplace);
        }

        private void Dessin_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    texte = "Au revoir";
                    ellipse = new Rectangle(200, 150, 80, 50);
                    //deplace = e.Location;
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    texte = "Bonjour";
                    ellipse = new Rectangle(200, 150, 50, 80);
                    //deplace = e.Location;
                    break;
            }
            deplace = e.Location;
            Refresh(); // mise a jour l'affichage
        }
        
    }
}

