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
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Projet_GenieLog
{
    [Serializable()]
    public class Perception : Exercices
    {
        private static Random rnd = new Random();
        public static string ruleNumber;
        public static int rndNumberShapes;
        public static int[,] rndNumbersTab = new int[3, 4];
        public static Forme[,] arrayFormes;
        public static List<Forme> listFormes = new List<Forme>();
        private string[,] arrayLetters = new string[3, 4] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" }, { "I", "J", "K", "L" } };


        public Perception()
        {

        }
        public Perception(List<Rule> ruleList) : base(ruleList)
        {
            
        }

        public static Perception deserializeXML() // Lit le fichier "rulePerception.xml et le cast dans un objet perception
        {
            
            StreamReader reader = new StreamReader("rulePerception.xml");
            Perception p = (Perception)new XmlSerializer(typeof(Perception)).Deserialize(reader);
            reader.Close();          
            return p;

        }

        public static string generateRule() // génère une règle aléatoire et la retourne, récupère aussi le numéro de la règle
        {
            int tmp = rnd.Next(0, 4);
            Perception p = deserializeXML();
            string rule = p.Rules[tmp].Text.ToString();
            ruleNumber = p.Rules[tmp].Number.ToString();

            return rule;
        }

        public int[,] generateRandomArray() // génère le tableau d'entiers aléatoires
        {            

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    rndNumbersTab[i, j] = rnd.Next(0, 10);                    
                }
            }

            return rndNumbersTab;

        }

        public void drawNumbers(PaintEventArgs e)// dessine les chiffres aléatoirement 
        {
            for (int i =0; i<3; i++)
            {
                for (int j =0; j<4;j++)
                {
                    e.Graphics.DrawString(rndNumbersTab[i, j].ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(43.0F + 105.0F * j, 43.0F + 95.0F * i));

                }
            }
        }


        public static void createColoredShape(Forme f, Form form) // permet de créer soit un rectangle soit un rond de couleur bleue ou jaune
        {
            int width = 50;
            int height = 50;
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = form.CreateGraphics();           
            
            if (f.Color == "Blue")
            {
                if (f.Shape == "Rectangle")
                {
                    formGraphics.FillRectangle(blueBrush, new Rectangle(f.PositionX, f.PositionY, width, height));                   
                }

                else
                {
                    formGraphics.FillEllipse(blueBrush, new Rectangle(f.PositionX, f.PositionY, width, height));
                    
                }
                blueBrush.Dispose();
                formGraphics.Dispose();
            }

            else
            {
                if (f.Shape == "Rectangle")
                {
                    formGraphics.FillRectangle(yellowBrush, new Rectangle(f.PositionX, f.PositionY, width, height));
                    
                }

                else
                {
                    formGraphics.FillEllipse(yellowBrush, new Rectangle(f.PositionX, f.PositionY, width, height));                   
                    
                }
                yellowBrush.Dispose();
                formGraphics.Dispose();

            }
        }


        public List<Forme> drawShapes() // génère les formes aléatoirement en fonction de la règle
        {
            int nbr; //nbr aleatoire pour choisir la forme
            int color; // nbr aleatoire pour choisir la couleur
            int cpt = 0; // compteur de formes pour la règle choisie
            rndNumberShapes = rnd.Next(3, 5);  // 3 ou 4 formes max                     
            arrayFormes = new Forme[3, 4];
            while (cpt < rndNumberShapes)
            {
                for (int i = 0; i < 3; i++) // on parcourt les emplacements des formes (3 lignes x 4 colonnes)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        switch (ruleNumber)
                        {

                            case "1": // l'utilisateur doit regarder les carrés jaunes
                            case "Regle1":
                                nbr = rnd.Next(1, 3);
                                if (nbr == 1) //1 -> carré
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 0 || cpt == rndNumberShapes) // 0 -> bleu
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);

                                    }

                                    else  // 1 -> jaune
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                        listFormes.Add(new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                        cpt++;
                                    }

                                }

                                //else if (cpt < i + 1)
                                //{
                                //    createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                //    arrayFormes[i, j] = new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]);
                                //    listFormes.Add(new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                //    cpt++;
                                //}
                                else
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 0)
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }

                                }
                                break;

                            case "2": // L'utilisateur doit regarder les carrés bleus
                            case "Regle2":
                                nbr = rnd.Next(1, 3);
                                if (nbr == 1) //1 -> carré
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 1 || cpt == rndNumberShapes) // 1 -> jaune
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else  // 0 -> bleu
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                        listFormes.Add(new Forme("Blue", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));

                                        cpt++;
                                    }

                                }
                                //else if (cpt < i + 1)
                                //{
                                //    createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                //    arrayFormes[i, j] = new Forme("Blue", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]);
                                //    listFormes.Add(new Forme("Blue", "Rectangle", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                //    cpt++;
                                //}
                                else
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 0)
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }

                                }
                                break;

                            case "3": // L'utilisateur doit regarder les ronds jaunes
                            case "Regle3":
                                nbr = rnd.Next(1, 3);
                                if (nbr == 1) //1 -> carré
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 0) // 0 -> bleu
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else  // 1 -> jaune
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }

                                }
                                //else if (cpt < i + 1)
                                //{
                                //    createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                //    arrayFormes[i, j] = new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]);
                                //    listFormes.Add(new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                //    cpt++;
                                //}
                                else
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 0 || cpt == rndNumberShapes)
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                        listFormes.Add(new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));

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
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else  // 1 -> jaune
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Rectangle", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }

                                }
                                //else if (cpt < i + 1)
                                //{
                                //    createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                //    arrayFormes[i, j] = new Forme("Blue", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]);
                                //    listFormes.Add(new Forme("Blue", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                //    cpt++;
                                //}
                                else
                                {
                                    color = rnd.Next(0, 2);
                                    if (color == 1 || cpt == rndNumberShapes)
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Yellow", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                    }
                                    else
                                    {
                                        //createColoredShape(25 + 105 * j, 30 + 95 * i, 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                        arrayFormes[i, j] = new Forme("Blue", "Ellipse", rndNumbersTab[i, j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j]);
                                        listFormes.Add(new Forme("Blue", "Ellipse", rndNumbersTab[i, j], i, j, arrayLetters[i, j]));
                                        cpt++;

                                    }

                                }
                                break;


                        }

                    }

                }
            }

            
            //Debug.WriteLine(listFormes[0] + " " + listFormes[1] + " " + listFormes[2]);
            return listFormes;            

        }

        public class Forme
        {
            public string Color { get; set; }
            public string Shape { get; set; }
            public int Value { get; set; }
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public string Letter { get; set; }

            public Forme()
            {

            }
            public Forme(string color, string shape, int value, int posX, int posY, string letter)
            {
                Color = color;
                Shape = shape;
                Value = value;
                PositionX = posX;
                PositionY = posY;
                Letter = letter;
            }

            public override string ToString()
            {
                string ch = "forme:" + Shape + " color:" + Color + " value:" + Value + " letter: " + Letter;
                return ch;
            }
        }

    }
} 