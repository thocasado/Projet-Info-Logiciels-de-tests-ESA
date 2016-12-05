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

namespace Projet_GenieLog
{
    [Serializable()]
    public class Perception : Exercices
    {
        private static Random rnd = new Random();
        private static string ruleNumber;
        public static int rndNumberShapes;
        

        public Perception()
        {

        }

        public Perception(List<Rule> ruleList) : base(ruleList)
        {

        }


        public static Perception deserializeXML()
        {
            // Lit le fichier "rulePerception.xml et le cast dans un objet perception"
            StreamReader reader = new StreamReader("rulePerception.xml");
            Perception p = (Perception)new XmlSerializer(typeof(Perception)).Deserialize(reader);
            reader.Close();

            return p;

        }

        public static string generateRule()
        {
            int tmp = rnd.Next(0, 4);
            Perception p = deserializeXML();
            string rule = p.Rules[tmp].Text.ToString();
            ruleNumber = p.Rules[tmp].Number.ToString();

            return rule;
        }


        //public static void generateXML()
        //{
        //    Perception p = new Perception();
        //    p.Rules.Add(new Rule(1, "Regle 1 haha"));
        //    p.Rules.Add(new Rule(2, "Regle 2 hiihih"));
        //    p.Rules.Add(new Rule(5, "Regle 5 hiihih"));

        //    // Sauvegarde l'objet hotel dans le fichier "rulePerception.xml"
        //    StreamWriter writer = new StreamWriter("rulePerception.xml");
        //    new XmlSerializer(typeof(Perception)).Serialize(writer, p);
        //    writer.Close();
        //}
        public static int[,] generateRandomArray() // méthode static pour pouvoir l'appeler dans FormPerception
        {
            int[,] randomNumbers = new int[3, 4];

            for (int i = 0; i < 3; i++) // génère un tableau 3*4 d'entiers aléatoires
            {
                for (int j = 0; j < 4; j++)
                {
                    randomNumbers[i, j] = rnd.Next(0, 10);
                }
            }

            return randomNumbers;

        }

        public static void drawNumbers(PaintEventArgs e) // dessine des chiffres aléatoires 
        {
            int[,] myArray = generateRandomArray();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    e.Graphics.DrawString(myArray[i, j].ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(43.0F + 105.0F * j, 43.0F + 95.0F * i));
                }
            }
        }

        public static void createColoredShape(int x, int y, int width, int height, string color, string shape, Form form) // permet de créer soit un rectangle soit un rond de couleur bleue ou jaune
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = form.CreateGraphics();

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


        public static void drawShapes() // génère les formes aléatoirement en fonction de la règle
        {
            int nbr; //nbr aleatoire pour choisir la forme
            int color; // nbr aleatoire pour choisir la couleur
            int cpt = 0; // compteur de formes pour la règle choisie
            //string ruleNumber = ruleNumber; // on appelle generateRule donc nouvel entier aleatoire :/
            rndNumberShapes = rnd.Next(3, 5);  // 3 ou 4 formes max

            for (int i = 1; i <= 3; i++) // on parcourt les emplacements des formes (3 lignes x 4 colonnes)
            {
                for (int j = 1; j <= 4; j++)
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
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle", Form.ActiveForm); }

                                else  // 1 -> jaune
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                    cpt++;
                                }

                            }

                            else if (cpt < i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0)
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Ellipse", Form.ActiveForm); }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
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
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Rectangle", Form.ActiveForm); }
                                else  // 0 -> bleu
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                    cpt++;
                                }

                            }
                            else if (cpt < i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle", Form.ActiveForm);
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0)
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Ellipse", Form.ActiveForm); }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
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
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle", Form.ActiveForm); }
                                else  // 1 -> jaune
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                }

                            }
                            else if (cpt < i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 0 || cpt == rndNumberShapes)
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Ellipse", Form.ActiveForm); }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
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
                                { createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Rectangle", Form.ActiveForm); }
                                else  // 1 -> jaune
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Rectangle", Form.ActiveForm);
                                }

                            }
                            else if (cpt < i)
                            {
                                createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                cpt++;
                            }
                            else
                            {
                                color = rnd.Next(0, 2);
                                if (color == 1 || cpt == rndNumberShapes)
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Yellow", "Ellipse", Form.ActiveForm);
                                }
                                else
                                {
                                    createColoredShape(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50, "Blue", "Ellipse", Form.ActiveForm);
                                    cpt++;

                                }

                            }
                            break;

                    }

                }
            }

        }

    }
} 