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

        private void createColoredShape (int x, int y, int width, int height, string color, string shape)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = this.CreateGraphics();
            if (color == "Blue")
            {
                if (shape == "Rectangle")
                {
                    formGraphics.FillRectangle(blueBrush, new Rectangle(x, y, width, height));
                    blueBrush.Dispose();
                    formGraphics.Dispose();
                }

                else
                {
                    formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height));
                    blueBrush.Dispose();
                    formGraphics.Dispose();
                }
            }

            else
            {
                if (shape == "Rectangle")
                {
                    formGraphics.FillRectangle(yellowBrush, new Rectangle(x, y, width, height));
                    yellowBrush.Dispose();
                    formGraphics.Dispose();
                }

                else
                {
                    formGraphics.FillEllipse(yellowBrush, new Rectangle(x, y, width, height));
                    yellowBrush.Dispose();
                    formGraphics.Dispose();
                }
            }
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
        private void generateShapes()
        {
            Random rnd = new Random();
            int nbr; //nbr aleatoire pour choisir la forme
            int color; // nbr aleatoire pour choisir la couleur
            int cpt = 0; // compteur de formes pour la règle choisie
            int nbrShapes;
            string ruleNumber = "Regle2";
            nbrShapes = rnd.Next(3, 5);  // 3 ou 4 formes max

            for (int i=1; i<=3;i++) // on parcourt les emplacements des formes (3 lignes x 4 colonnes)
            {
                for (int j=1;j<=4;j++)
                {
                    
                    switch (ruleNumber)
                    {
                        
                        case "1": // l'utilisateur doit regarder les carrés jaunes
                        case "Regle1":
                            nbr = rnd.Next(1, 3);
                            if (nbr == 1 ) //1 -> carré
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0 || cpt == nbrShapes) // 0 -> bleu
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Blue","Rectangle"); }

                                else  // 1 -> jaune
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Yellow","Rectangle");
                                    cpt++;
                                }

                            }

                            else if(cpt<i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Yellow","Rectangle");
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0)
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Blue","Ellipse"); }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Yellow","Ellipse");
                                }

                            }
                            break;

                        case "2": // L'utilisateur doit regarder les carrés bleus
                        case "Regle2":
                            nbr = rnd.Next(1, 3);
                            if (nbr == 1) //1 -> carré
                            {
                                color = rnd.Next(0, 2);
                                if (color == 1 || cpt == nbrShapes) // 1 -> jaune
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Yellow","Rectangle"); }
                                else  // 0 -> bleu
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Blue","Rectangle");
                                    cpt++;
                                }

                            }
                            else if(cpt<i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle");
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0)
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Blue","Ellipse"); }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50,"Yellow","Ellipse");
                                }

                            }
                            break;

                        case "3": // L'utilisateur doit regarder les ronds jaunes
                        case "Regle3":
                            nbr = rnd.Next(1, 3);
                            if (nbr == 1) //1 -> carré
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0 ) // 0 -> bleu
                                { createBlueSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                                else  // 1 -> jaune
                                {
                                    createYellowSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                                }

                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0 || cpt == nbrShapes)
                                { createBlueCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                                else
                                {
                                    createYellowCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                                    cpt++;
                                }

                            }
                            break;

                        case "4": // L'utilisateur doit regarder les ronds bleus
                        case "Regle4":
                            nbr = rnd.Next(1, 3);
                            if (nbr == 1) //1 -> carré
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0) // 0 -> bleu
                                { createBlueSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                                else  // 1 -> jaune
                                {
                                    createYellowSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                                }

                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 1 || cpt == nbrShapes)
                                { 
                                    createYellowCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                                }
                                else
                                {
                                    createBlueCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                                    cpt++;

                                }

                            }
                            break;

                    }
                    
                }
            }
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            generateShapes();
            
        }

        private void FormPerception_Load(object sender, EventArgs e)
        {

            
        }

        
    }
}
