using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetSudoku
{
    public class Case : TextBox
    {
        #region attributs
        private Sudoku jeu;
        private int i, j;
        private TextBox textbox;
        #endregion attributs

        public TextBox tb
        {
            get { return textbox; }
            set { textbox = value; }
        }

        public Case(Sudoku _jeu, int _i, int _j)
        {
            jeu = _jeu;
            i = _i * 35;
            j = _j * 35;

            textbox = new TextBox();
            textbox.Anchor = AnchorStyles.None;
            textbox.Height = 30;
            textbox.Width = 30;
            textbox.MaxLength = 1;
            textbox.Visible = true;
            textbox.Location = new Point(150+i,65+j);
            textbox.TextAlign = HorizontalAlignment.Center;
            textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            jeu.Controls.Add(textbox);
        }

        
    }
}
