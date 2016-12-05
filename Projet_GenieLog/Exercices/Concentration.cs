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
using System.Xml.Linq;


namespace Projet_GenieLog
{
    public class Concentration : Exercices
    {
        
        public string _consigne { get; set; }
        public string _boutonForme { get; set; }
        public string _boutonCouleur { get; set; }
        public string _boutonNbPoint { get; set; }
        


        public Concentration(string consigne, string boutonF, string boutonC, string boutonNbP)
        {
            _consigne = consigne;
            _boutonForme = boutonF;
            _boutonCouleur = boutonC;
            _boutonNbPoint = boutonNbP;

        }

        public static Concentration selectionRègle()
        {
            int nbDeRègleTotal = 6;
            #region Deserialisation
            Concentration[] regles = new Concentration[nbDeRègleTotal];
            XDocument doc = XDocument.Load("ruleConcentration.xml");
            var ensembleRegles = doc.Descendants("Regles").First();
            var regle = ensembleRegles.Descendants("regle");

            foreach (var r in regle)
            {
                regles[(int)r.Attribute("id") - 1] = new Concentration((string)r.Attribute("consigne"), (string)r.Attribute("boutonForme"), (string)r.Attribute("boutonNbP"), (string)r.Attribute("boutonCouleur"));
            }

            #endregion
            Random rnd = new Random();
            int a= rnd.Next(0, nbDeRègleTotal);
            return regles[a];

        }

        public static void createColoredShape(string color, string shape,int nbPoint, Form form) // permet de créer soit un rectangle soit un rond de couleur bleue ou jaune
        {
            int x = 129;//abs forme(fixe)
            int y = 229;//ord forme(fixe)
            int width = 50;
            int height = 50;
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blackBrush= new SolidBrush(Color.Black);

            Graphics formGraphics = form.CreateGraphics();

            switch(color)
            {
                case "blue":
                switch(shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(blueBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height)); //Chercher pour faire triangle
                        break;
                }
                
                    blueBrush.Dispose();
                    formGraphics.Dispose();
                
                    
                break;
                case "yellow" :
                switch (shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(yellowBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(yellowBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillEllipse(yellowBrush, new Rectangle(x, y, width, height)); //Chercher pour faire triangle
                        break;
                }
                    yellowBrush.Dispose();
                    formGraphics.Dispose();

                break;
                
                case "red" :
                switch (shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(redBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(redBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillEllipse(redBrush, new Rectangle(x, y, width, height)); //Chercher pour faire triangle
                        break;
                }
                    redBrush.Dispose();
                    formGraphics.Dispose();
                break;
            }

            
                
        }

        public static void createPoint(int nbPoint, Form form)
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

        public static void generateShape()
        {

        }
    }
}