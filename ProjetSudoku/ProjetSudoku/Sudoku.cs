using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetSudoku
{
    public partial class Sudoku : Form
    {
        #region attributs
        private Case[][] grille;
        #endregion attributs

        public Sudoku()
        {
            InitializeComponent();
            grille = new Case[9][];
            for (int i=0;i<9;i++)
            {
                grille[i] = new Case[9];
                for (int j = 0; j < 9; j++)
                    grille[i][j] = new Case(this, i, j);
                Controls.Add(panelDessin); // On ajoute le panel déjà dessiné la grille au Sudoku 
            }
            ouvrirUneGrilleToolStripMenuItem.Visible = false;
            aideToolStripMenuItem.Visible = false;
        }

        #region Interface
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ouvrirUneGrilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Fichier txt|*.txt";
            openDialog.FilterIndex = 1;
            openDialog.RestoreDirectory = true;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                aideToolStripMenuItem.Visible = true;
                StreamReader read = new StreamReader(openDialog.FileName);
                for (int i = 0; i < 9; i++)
                {
                    string ligne = read.ReadLine();
                    for (int j = 0; j < 9; j++)
                    {
                        this.grille[j][i].tb.TextChanged -= this.GestionEvent_TextChanged;
                        this.grille[j][i].tb.DoubleClick -= this.GestionEvent_DoubleClick;
                        grille[j][i].tb.BackColor = Color.White;
                        if (ligne[j].ToString() != "0")
                        {
                            grille[j][i].tb.Text = ligne[j].ToString();
                            grille[j][i].tb.ReadOnly = true; // cette propriete ne permet pas au joueur de modifier les cases déjà contenues les numéros
                            grille[j][i].tb.BackColor = Color.Aquamarine;
                            this.grille[j][i].tb.TextChanged -= this.GestionEvent_TextChanged; // lorsque le joueur veut ouvrir une nouvelle grille de Sudoku,
                                                                                               // on enlève cet événement pour éviter le ReadOnly de toutes les cases.
                        }
                        else
                        {
                            grille[j][i].tb.Text = "";
                            grille[j][i].tb.ReadOnly = false;
                            this.grille[j][i].tb.TextChanged += new System.EventHandler(this.GestionEvent_TextChanged); // ce gestionnaire d'evenement permet de connaitre s'il y a un changement dans une case.
                            this.grille[j][i].tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GestionEvent_KeyPress); // ce gestionnaire d'evenement permet de saisir seulement les numeros depuis le clavier.
                            this.grille[j][i].tb.DoubleClick += new System.EventHandler(this.GestionEvent_DoubleClick);
                        }
                    }
                }
                read.Close();
            }
        }

        private void panelDessin_Paint(object sender, PaintEventArgs e)
        {
            // Ce panel sert à dessiner la grille Sudoku et les lignes qui divisent les cases de 3*3
            Pen p = new Pen(Color.Indigo, 3);
            Rectangle rect = new Rectangle(3, 3, 313, 310);
            e.Graphics.DrawRectangle(p, rect);
            e.Graphics.DrawLine(p, new Point(107, 3), new Point(107, 314));
            e.Graphics.DrawLine(p, new Point(212, 3), new Point(212, 314));
            e.Graphics.DrawLine(p, new Point(5, 105), new Point(317, 105));
            e.Graphics.DrawLine(p, new Point(5, 210), new Point(317, 210));
        }

        private void butJouer_Click(object sender, EventArgs e)
        {
            pageAccueil.Visible = false;
            butPageAccueil.Visible = true;
            richtxtManuel.Visible = false;
            ouvrirUneGrilleToolStripMenuItem.Visible = true;
            aideToolStripMenuItem.Visible = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.grille[j][i].tb.TextChanged -= this.GestionEvent_TextChanged;
                }
            }
        }

        private void butInstruction_Click(object sender, EventArgs e)
        {
            richtxtManuel.Visible = true;
        }

        private void butPageAccueil_Click(object sender, EventArgs e)
        {
            richtxtManuel.Visible = false;
            pageAccueil.Visible = true;
            butPageAccueil.Visible = false;
            ouvrirUneGrilleToolStripMenuItem.Visible = false;
            aideToolStripMenuItem.Visible = false;
            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    grille[i][j].tb.Text = "";
                    grille[i][j].tb.BackColor = Color.White;
                    this.grille[j][i].tb.DoubleClick -= this.GestionEvent_DoubleClick;
                }
            }
        } 
        #endregion

        #region Regles
        public bool VerifierRegle(int x, int y) // la fonction recoit en paramètre 2 nombres i et j représentant la position de case
        {
            for (int i = 0; i < 9; i++) // Vérifier la validation des nombres entrés dans les 9*9 cases horizontales et verticales
            {
                if (grille[x][y].tb.Text == grille[i][y].tb.Text && i != x)
                    return true;
                if (grille[x][y].tb.Text == grille[x][i].tb.Text && i != y)
                    return true;
            }
            for (int i = 3 * (x / 3); i < 3 * (x / 3) + 3; i++) // Vérifier la validation des nombres entrés dans les 3*3 cases horizontales et verticales
            {
                for (int j = 3 * (y / 3); j < 3 * (y / 3) + 3; j++)
                {
                    if (i != x && j != y)
                    {
                        if (grille[x][y].tb.Text == grille[i][j].tb.Text)
                            return true;
                    }
                }
            }
            return false;
        }

        public void estGagnant()
        {
            bool gagnant = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.Text == "")
                    {
                        gagnant = false;                        
                    }
                }
            }
            if (gagnant)
                MessageBox.Show("BRAVO ! VOUS AVEZ GAGNE !", "FELICITATION", MessageBoxButtons.OKCancel);
        } 
        #endregion

        #region Evenements
        private void GestionEvent_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.Focused == true && grille[i][j].tb.Text != "")
                    {
                        if (VerifierRegle(i, j))
                        {
                            grille[i][j].tb.BackColor = Color.Yellow;
                            MessageBox.Show("NUMERO INVALIDE: VEUILLEZ REESSAYER DE NOUVEAU !", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            grille[i][j].tb.BackColor = Color.White;
                            grille[i][j].tb.Text = "";
                        }
                        estGagnant();                        
                    }
                }
            }
        }

        private void GestionEvent_KeyPress(object sender, KeyPressEventArgs e)         
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // on vérifie si le caractère entrée n'est pas un nombre
            {                                               // et est different de la touche BackSpace
                 e.Handled = true;
            }                           
        }
        #endregion

        #region Aides
        private void GestionEvent_DoubleClick(object sender, EventArgs e)
        {
            // on va prendre une chaine de numero (de 1 à 9) et va tester chaque valeur dans la case sélectionnée
            // on affecte chaque valeur dans cette case et vérifie la validité de celle-ci.
            // on fait attention à l'événement TextChanged puisque, à chaque fois qu'on affecte une valeur, le programme appelle cet événement
            string[] chaine;
            chaine = new string[9];
            for (int k = 0; k < 9; k++)
            {
                chaine[k] = "";
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.Focused == true)
                    {
                        string temp = grille[i][j].tb.Text;
                        this.grille[i][j].tb.TextChanged -= this.GestionEvent_TextChanged; // on enlève ici le gestionnaire TextChanged pour qu'on puisse
                        grille[i][j].tb.BackColor = Color.Red;                             // vérifier un nombre possible dans une case. 

                        for (int k = 0; k < 9; k++)
                        {
                            grille[i][j].tb.Text = (k + 1).ToString(); ;
                            if (!VerifierRegle(i, j))
                            {
                                chaine[k] = (k + 1).ToString();
                            }
                        }
                        grille[i][j].tb.Text = temp;
                    }
                }
            }
            string result = "LES VALEURS POSSIBLES : ";
            for (int i = 0; i < 9; i++) // Apres la vérification, on affiche une fenêtre indiquant les numéros possibles ....
            {
                if (chaine[i] != "")
                    result += chaine[i] + " ";
            }
            MessageBox.Show(result, "AIDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 9; i++) // ... et on remet les cases à son état initial (la couleur, le gestionnaire TextChanged)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.BackColor == Color.Red)
                    {
                        grille[i][j].tb.BackColor = Color.White;
                        this.grille[i][j].tb.TextChanged += new System.EventHandler(this.GestionEvent_TextChanged);
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // Ici, c'est le menu d'Aide
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.Text == "")
                    {
                        this.grille[i][j].tb.TextChanged -= this.GestionEvent_TextChanged; // même principe qu'au-dessus, on enlève l'événement TextChanged
                        grille[i][j].tb.Text = sender.ToString(); // cette ligne sert à identifier quelle est la valeur choisie dans le menu
                        if (!VerifierRegle(i, j))
                        {
                            grille[i][j].tb.Text = "";
                            grille[i][j].tb.BackColor = Color.Violet;
                        }
                        else
                            grille[i][j].tb.Text = "";
                    }
                }
            }
            MessageBox.Show("Suite !", "AIDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i][j].tb.Text == "")
                    {
                        this.grille[i][j].tb.TextChanged += new System.EventHandler(this.GestionEvent_TextChanged);
                        if (grille[i][j].tb.BackColor == Color.Violet)
                            grille[i][j].tb.BackColor = Color.White;
                    }
                }
            }
        } 
        #endregion

           
                        
    }
}
