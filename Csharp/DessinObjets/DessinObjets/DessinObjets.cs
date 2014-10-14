using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DessinObjets;
namespace DessinObjets
{
    public partial class DessinObjets : UserControl
    {
        #region attributs
        List<Noeud> noeuds = new List<Noeud>();
        List<Trait> traits = new List<Trait>();
        Noeud noeudCourant = null;
        Point pointCourant = Point.Empty;
        bool enDéplacement;
        bool dessinTrait;

        Color couleurParDéfaut = Color.Black;
        int epaisseurParDéfaut = 1;
        Size tailleParDéfaut = new Size(10, 15);

        Point origin = new Point(0, -20);
        float zoom = 1;       
        #endregion attributs

        #region proprietes
        [Category("Configuration"), Description("Couleur par défaut")]
        public Color CouleurParDéfaut
        {
            get { return couleurParDéfaut; }
            set { couleurParDéfaut = value; }
        }
        [Category("Configuration"), Description("Epaisseur par défaut")]
        public int EpaisseurParDéfaut
        {
            get { return epaisseurParDéfaut; }
            set { epaisseurParDéfaut = value; }
        }
        #endregion

        #region delegate
        public delegate void DrawnNode(Object sender, NodeDrawnArg arg);
        #endregion

        public class NodeDrawnArg : EventArgs
        {
            private Noeud noeud;
            public Noeud Noeud
            {
                get {return noeud;}
                set { noeud = value;}
            }
            public NodeDrawnArg (Noeud in_noeud)
            {
                noeud = in_noeud;
            }
        }
        String message = " ";

        #region event
        public event DrawnNode drawnNodeEvent;
        #endregion

        public DessinObjets()
        {
            InitializeComponent();
            //moinsToolStripMenuItem.Enabled = false;
            this.MouseWheel += DessinObjets_MouseWheel;
        }

        private void DessinObjets_MouseDown(object sender, MouseEventArgs e)
        {
            noeudCourant = NoeudCourant(e);
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    {
                        if (déplacement.Checked)
                        {
                            if (noeudCourant != null)
                            {
                                enDéplacement = true;
                            }
                        }
                        else
                        {
                            if (noeudCourant == null)
                            {
                                Noeud noeud = new Noeud(e.Location, new Size(10, 15), couleurParDéfaut, epaisseurParDéfaut);
                                noeuds.Add(noeud);
                                this.drawnNodeEvent(this, new NodeDrawnArg(noeud));
                            }
                            else dessinTrait = true;
                        }
                        break;
                    }
                case System.Windows.Forms.MouseButtons.Right:
                    {
                        if (noeudCourant != null)
                        {
                            string[] libellés = new string[] { "Supprimer", "Modifier" };
                            ContextMenuStrip cm = new ContextMenuStrip();
                            foreach (string libel in libellés)
                            {
                                ToolStripMenuItem menuItem = new ToolStripMenuItem(libel);
                                menuItem.Click += menuItem_Click;
                                cm.Items.Add(menuItem);
                            }
                            cm.Show(this, e.Location);
                            /*
                            Parametres d = new Parametres();
                            d.Couleur = noeudCourant.Couleur;
                            d.Épais = noeudCourant.Épaisseur;
                            if (d.ShowDialog() == DialogResult.OK)
                            {
                                noeudCourant.Couleur = d.Couleur;
                                noeudCourant.Épaisseur = d.Épais;
                            }
                             */
                        }
                        break;
                    }
            }
            Refresh();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            switch (tm.Text)
            {
                case "Modifier":
                    {
                        Parametres d = new Parametres();
                        d.Couleur = noeudCourant.Couleur;
                        d.Épais = noeudCourant.Épaisseur;
                        if (d.ShowDialog() == DialogResult.OK)
                        {
                            noeudCourant.Couleur = d.Couleur;
                            noeudCourant.Épaisseur = d.Épais;
                        }
                        break;
                    }    
                    
                case "Supprimer":
                    {
                        // dans un foreach, il est impossible de Remove un element ds une liste
                        // il faut creer une liste intermediare aSupprimer
                        List<Trait> aSupprimer = new List<Trait>(); 
                        foreach (Trait tr in traits)
                            if (tr.Destination == noeudCourant || tr.Source == noeudCourant)
                                aSupprimer.Add(tr);
                        foreach (Trait tr in aSupprimer)
                            traits.Remove(tr);
                        noeuds.Remove(noeudCourant);
                    }
                    break;
            }
        }
 
        private Noeud NoeudCourant(MouseEventArgs e)
        {
            foreach (Noeud re in noeuds)
            {
                if (re.Contains(e.Location))
                {
                    return re;
                }
            }
            return null;
        }

        private void DessinObjets_Paint(object sender, PaintEventArgs e)
        {
            foreach (Noeud n in noeuds)
                n.Dessine(e.Graphics,zoom,origin);
            foreach (Trait t in traits)
                t.Dessine(e.Graphics);
            if (pointCourant != Point.Empty)
            {
                Noeud fin = new Noeud(pointCourant, tailleParDéfaut, couleurParDéfaut, epaisseurParDéfaut);
                fin.Dessine(e.Graphics,zoom,origin);
                e.Graphics.DrawLine(Pens.Red, noeudCourant.Centre, pointCourant);
            }
        }

        private void DessinObjets_MouseUp(object sender, MouseEventArgs e)
        {
                enDéplacement = false;
                if (dessinTrait)
                {
                    Noeud fin = NoeudCourant(e);
                    if (fin == null)
                    {
                        fin = new Noeud(e.Location, new Size(10, 15), Color.Black, 2);
                        noeuds.Add(fin);
                    }
                    Trait t = new Trait(noeudCourant, fin, couleurParDéfaut, 1);
                    traits.Add(t);
                    Refresh();
                    dessinTrait = false;
                }
                //noeudCourant = null;
                pointCourant = Point.Empty;
        }
        
        private void DessinObjets_MouseMove(object sender, MouseEventArgs e)
        {
            // si noeud en deplacement, deplacer le noeud
            if (enDéplacement)
            {
                if (noeudCourant != null)
                {
                    noeudCourant.Move(e.Location);
                }
            }
            if (dessinTrait)
                pointCourant = e.Location;
            Refresh();
        }

        private Noeud TrouveNoeud(Point p)
        {
            foreach (Noeud re in noeuds)
            {
                if (re.Contains(p))
                {
                    return re;
                }
            }
            return null;
        }
                
        private Noeud NoeudParDéfaut(Point point)
        {
            return new Noeud(point, tailleParDéfaut, couleurParDéfaut, epaisseurParDéfaut);
        }
        /*
        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            couleurParDéfaut = Color.Red;    
        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (epaisseurParDéfaut < 10)
            {
                epaisseurParDéfaut++;
                moinsToolStripMenuItem.Enabled = true;
            }
            if (epaisseurParDéfaut == 10) plusToolStripMenuItem.Enabled = false;
        }

        private void moinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (epaisseurParDéfaut > 1)
            {
                epaisseurParDéfaut--;
                plusToolStripMenuItem.Enabled = true;
            }
            if (epaisseurParDéfaut == 1) moinsToolStripMenuItem.Enabled = false;
        }
        */
        private void toolStripButtonCouleur_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            d.Color = couleurParDéfaut;
            if (d.ShowDialog() == DialogResult.OK) 
                couleurParDéfaut = d.Color;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            noeuds.Clear();
            traits.Clear();
            this.Refresh();
        }
 
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"  ; //"csv files (*.csv)|*.csv|All files (*.*)|*.*"
            saveDialog.FilterIndex = 1 ;
            saveDialog.RestoreDirectory = true ;
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fichier = saveDialog.FileName;
                StreamWriter sw = new StreamWriter(fichier);
                /*
                sw.WriteLine(noeuds.Count.ToString()); // calculer le nombre de noeud
                foreach (Noeud n in noeuds)
                {
                    //Sauvegarde d'un noeud
                    sw.WriteLine(n.ToString()); // ajouter dans la classe Noeud une fonction ToString() même si ca a l'air marche
                }
                sw.WriteLine(traits.Count.ToString()); // calculer le nombre de trait
                foreach (Trait t in traits)
                {
                    sw.WriteLine(t.ToString());
                }
                */
                sw.WriteLine("<!--?xml version=\"1.0\" encoding=\"UTF-8\" ?--> ");
                sw.WriteLine("<dessin>");
                foreach (Noeud r in noeuds)
                {
                    sw.WriteLine(r.ToXML());
                }
                foreach (Trait tr in traits)
                {
                    sw.WriteLine(tr.ToXML());
                }
                sw.WriteLine("</dessin>");
                sw.Close();
            }
        }

        private void WriteLine()
        {
            throw new NotImplementedException();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Fichier xml|*.xml";
            openDialog.FilterIndex = 1 ;
            openDialog.Title = "Choisir le fichier";
            openDialog.RestoreDirectory = true ;
            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                /*
                noeuds.Clear();
                traits.Clear();
                StreamReader sw = new StreamReader(openDialog.FileName);
                int nbNoeuds = int.Parse(sw.ReadLine());
                // lecture de Noeud
                for (int i = 0; i < nbNoeuds && !sw.EndOfStream; i++)
                {
                     // ligne suivante
                    string champ = sw.ReadLine();
                    // traitement d'une ligne du fichier
                    Noeud n = new Noeud(champ);
                    noeuds.Add(n);
                }
                int nbTraits = int.Parse(sw.ReadLine());
                // lecture de Trait
                for (int i = 0; i < nbTraits && !sw.EndOfStream; i++)
                {
                    // ligne suivante
                    string champ = sw.ReadLine();
                    // traitement d'une ligne du fichier
                    Trait t = new Trait(champ, noeuds);
                    traits.Add(t);
                }
                */

                XmlDocument hieu = new XmlDocument();
                hieu.Load(openDialog.FileName);
                foreach (XmlNode xN in hieu.ChildNodes)
                {
                    if (xN.Name == "dessin")
                    {
                        foreach (XmlNode xNN in xN.ChildNodes)
                        {
                            if (xNN.Name == "noeud")
                            {
                                Noeud n = new Noeud(xNN);
                                noeuds.Add(n);
                            }
                            if (xNN.Name == "trait")
                            {
                                Trait t = new Trait(xNN, noeuds);
                                traits.Add(t);
                            }
                        }
                    }

                }                
            }
            Refresh();
        }

        private void DessinObjets_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if (e.Delta > 0)
                {
                    zoom *= 1.1f;
                    if (zoom > 15f)
                        zoom = 15f;
                }
            }
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            switch (e.Type)
            {
                case ScrollEventType.First:
                    break;
                case ScrollEventType.Last:
                    break;
                case ScrollEventType.ThumbTrack:
                    origin.Y =-e.NewValue;
                    break;
                case ScrollEventType.EndScroll:
                    origin.Y = -e.NewValue;
                    break;
            }
            Refresh();
        }

        private void DessinObjets_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    origin.Y += 1;
                    break;
                case Keys.Up:
                    origin.Y -= 1;
                    break;
                case Keys.PageDown:
                    origin.Y += 50;
                    break;
                case Keys.PageUp:
                    origin.Y -= 50;
                    break;
                case Keys.Left:
                    origin.X += 1;
                    break;
                case Keys.Right:
                    origin.X -= 1;
                    break;
                case Keys.Home:
                    origin.X += 50;
                    break;
                case Keys.End:
                    origin.X -= 50;
                    break;
            }
            Refresh();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDocument Impression = new PrintDocument();
            Impression.PrintPage += Impression_PrintPage;
            Impression.Print();
        }

        private void Impression_PrintPage(object sender, PrintPageEventArgs e)
        {
            foreach (Noeud n in noeuds)
                n.Dessine(e.Graphics,zoom,origin);
            foreach (Trait t in traits)
                t.Dessine(e.Graphics);
        }

        private void PrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ptPrev = new PrintPreviewDialog();
            PrintDocument Impression = new PrintDocument();
            Impression.PrintPage += Impression_PrintPage;
            ptPrev.Document = Impression;
            ptPrev.ShowDialog();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (e.Type)
            {
                case ScrollEventType.First:
                    break;
                case ScrollEventType.Last:
                    break;                
                case ScrollEventType.ThumbTrack:
                    origin.X = -e.NewValue;
                    break;
                case ScrollEventType.EndScroll:
                    origin.X = -e.NewValue;
                    break;
            }
            Refresh();
        }

        
    }
}
    


