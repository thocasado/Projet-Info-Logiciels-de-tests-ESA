using Projet_GenieLog.View;
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


namespace Projet_GenieLog
{
    public class Forme // mettre ici la fonction createShape généralisée + nouveau constructeur pour les formes de Concentration (optimisation)  
    {
        public string couleur { get; set; }
            public string forme  { get; set; }
            public int valeur { get; set; }
            public int positionX { get; set; }
            public int positionY { get; set; }
            public string lettre { get; set; }

            public Forme(string c, string f, int posX, int posY)
            {
                couleur = c;
                forme = f;
                positionX = posX;
                positionY = posY;
            }
            public Forme(string c, string f, int v, int posX, int posY, string l)
            {
                couleur = c;
                forme = f;
                valeur = v;
                positionX = posX;
                positionY = posY;
                lettre = l;
            }


            public static void creationFormeColorée(Forme f, Form form) // la mettre dans la classe forme et la généraliser avec celle de perception
            {//redimensionner taille forme(les faire plus grandes)
                int width = 50;
                int height = 50;
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
                SolidBrush redBrush = new SolidBrush(Color.Red);
                SolidBrush blackBrush = new SolidBrush(Color.Black);

                Graphics formGraphics = form.CreateGraphics();
                Point[] triangle = new Point[] { new Point(129, 279), new Point(179, 279), new Point(154, 229) };//sommet gauche, sommet droite, sommet haut

                switch (f.couleur)
                {
                    case "Blue":
                        switch (f.forme)
                        {
                            case "Rectangle":

                                formGraphics.FillRectangle(blueBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Rond":
                                formGraphics.FillEllipse(blueBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Triangle":
                                formGraphics.FillPolygon(blueBrush, triangle);//(blueBrush, new Rectangle(x, y, width, height)); //Chercher pour faire triangle
                                break;
                        }

                        blueBrush.Dispose();
                        formGraphics.Dispose();



                        break;
                    case "Yellow":
                        switch (f.forme)
                        {
                            case "Rectangle":

                                formGraphics.FillRectangle(yellowBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Rond":
                                formGraphics.FillEllipse(yellowBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Triangle":
                                formGraphics.FillPolygon(yellowBrush, triangle);
                                break;
                        }


                        yellowBrush.Dispose();
                        formGraphics.Dispose();

                        break;

                    case "Red":
                        switch (f.forme)
                        {
                            case "Rectangle":

                                formGraphics.FillRectangle(redBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Rond":
                                formGraphics.FillEllipse(redBrush, new Rectangle(f.positionX, f.positionY, width, height));
                                break;

                            case "Triangle":
                                formGraphics.FillPolygon(redBrush, triangle);
                                break;
                        }

                        redBrush.Dispose();
                        formGraphics.Dispose();
                        break;
                }



            }

            public static void creationPoint(int nbPoint, Form form)
            {
                int width = 5;
                int height = 5;
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Graphics formGraphics = form.CreateGraphics();

                switch (nbPoint)
                {
                    case 1:
                        formGraphics.FillEllipse(blackBrush, new Rectangle(150, 250, width, height));
                        break;

                    case 2:
                        formGraphics.FillEllipse(blackBrush, new Rectangle(140, 235, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(160, 235, width, height));
                        break;
                    case 3:
                        formGraphics.FillEllipse(blackBrush, new Rectangle(140, 235, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(150, 252, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(160, 235, width, height));
                        break;
                    case 4:
                        formGraphics.FillEllipse(blackBrush, new Rectangle(160, 270, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(140, 235, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(140, 270, width, height));
                        formGraphics.FillEllipse(blackBrush, new Rectangle(160, 235, width, height));
                        break;
                    default:
                        break;
                }

                blackBrush.Dispose();
                formGraphics.Dispose();
            }

            public override string ToString()
            {
                string ch = "forme:" + forme + " color:" + couleur + " value:" + valeur + " letter: " + lettre;
                return ch;
            }
        }



    
}
