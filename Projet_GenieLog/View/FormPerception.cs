using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GenieLog.View
{
    public partial class FormPerception : Form
    {

        public FormPerception()
        {
            InitializeComponent();
        }

        private void createBlueCircle(int x, int y, int width, int height) // permet de creer un cercle bleu
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height));
            blueBrush.Dispose();
            formGraphics.Dispose();
        }

        private void createYellowCircle(int x, int y, int width, int height) // permet de creer un cercle  jaune
        {
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(yellowBrush, new Rectangle(x, y, width, height));
            yellowBrush.Dispose();
            formGraphics.Dispose();
        }

        private void createYellowSquare(int x, int y, int width, int height) // permet de creer un carré jaune
        {
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(yellowBrush, new Rectangle(x, y, width, height));
            yellowBrush.Dispose();
            formGraphics.Dispose();
        }
        private void createBlueSquare(int x, int y, int width, int height) // permet de creer un carré bleu
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(blueBrush, new Rectangle(x, y, width, height));
            blueBrush.Dispose();
            formGraphics.Dispose();
        }
        private void randomizeShapes()
        {
            Random rnd = new Random();
            int nbr;
            int color;

            for (int i=1; i<=3;i++) // on parcourt les emplacements des formes (3 lignes x 4 colonnes)
            {
                for (int j=1;j<=4;j++)
                {
                    nbr = rnd.Next(1, 3);
                    if(nbr == 1) //1 -> carré
                    {
                        color = rnd.Next(0, 2);
                        if(color==0) // 0 -> bleu
                        { createBlueSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                        else // 1 -> jaune
                        {
                            createYellowSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                        }
                        
                    }
                    else
                    {
                        color = rnd.Next(0, 2);
                        if (color == 0)
                        { createBlueCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                        else
                        {
                            createYellowCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                        }
                        
                    }
                    
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            randomizeShapes();
            
        }

        private void FormPerception_Load(object sender, EventArgs e)
        {

            
        }

        
    }
}
