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
        //voir comment effacer le dessin
        public string _consigne { get; set; }
        public string _boutonForme { get; set; }
        public string _boutonCouleur { get; set; }
        public string _boutonNbPoint { get; set; }
        


        public Concentration(string consigne, string boutonF, string boutonNbP, string boutonC)
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

        public static void createColoredShape(string color, string shape, Form form) // permet de créer soit un rectangle soit un rond de couleur bleue ou jaune
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
            Point[] triangle = new Point[] { new Point(129, 279), new Point(179, 279), new Point(154, 229) };//sommet gauche, sommet droite, sommet haut

            switch(color)
            {
                case "Blue":
                switch(shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(blueBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillPolygon(blueBrush,triangle);//(blueBrush, new Rectangle(x, y, width, height)); //Chercher pour faire triangle
                        break;
                }
                    formGraphics.Dispose();
                    blueBrush.Dispose();
                    
                
                    
                break;
                case "Yellow" :
                switch (shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(yellowBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(yellowBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillPolygon(yellowBrush, triangle);
                        break;
                }
                    
                    formGraphics.Dispose();
                    yellowBrush.Dispose();

                break;
                
                case "Red" :
                switch (shape)
                {
                    case "Rectangle" :
                
                    formGraphics.FillRectangle(redBrush, new Rectangle(x, y, width, height));
                    break;

                    case "Rond" :
                        formGraphics.FillEllipse(redBrush, new Rectangle(x, y, width, height));
                        break;

                    case "Triangle":
                        formGraphics.FillPolygon(redBrush, triangle); 
                        break;
                }
                    
                    formGraphics.Dispose();
                    redBrush.Dispose();
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

        public static string[] generateShape(int compteur,string []valAuxRep, Form form) //le tableau valAuxRep contient les paramètres de la forme précédente et la valeur du paramètre conservé
        {
            Random r = new Random();
            string forme="";
            string couleur="";
            int nbPoints = 0; 
            //string[] valAux = new string[3];//tableau qui conserve les valeurs du tirage précédent pour les 3 paramètres.
            int conserve = r.Next(1, 4); //premier random pour savoir quel paramètre on conserve entre forme,couleur et nbPoint
                                         //1=forme, 2= couleur 3=nbPoint  -> va nous permettre de savoir la bonne réponse.
            // C'est ce que la fonction va renvoyer 
            #region traitement des images suivants la première 
            if (compteur != 1)
            {
                switch (conserve)
                {
                    case 1: // on conserve la forme donc on change les autres paramètres 
                        do
                        {
                            int rC = r.Next(1, 4);
                            switch (rC)
                            {
                                case 1:
                                    couleur = "Blue";
                                    break;
                                case 2:
                                    couleur = "Yellow";
                                    break;
                                case 3:
                                    couleur = "Red";
                                    break;
                            }
                        }
                        while (valAuxRep[1] == couleur);
                        valAuxRep[1] = couleur;

                        do
                        {
                            int rP = r.Next(0, 5);
                            nbPoints = rP;
                        }
                        while (valAuxRep[2] == nbPoints.ToString());
                        valAuxRep[2] = nbPoints.ToString();

                        
                        break;
                            

                    case 2://on conserve la couleur donc on change les autres paramètres

                        do
                        {
                            int rF = r.Next(1, 4);

                            switch (rF)
                            {
                                case 1:
                                    forme = "Rectangle";
                                    break;
                                case 2:
                                    forme = "Rond";
                                    break;
                                case 3:
                                    forme = "Triangle";
                                    break;
                            }
                        }
                        while (valAuxRep[0] == forme);
                        valAuxRep[0] = forme;
                        
                        do
                        {
                            int rP = r.Next(0, 5);
                            nbPoints = rP;
                        }
                        while (valAuxRep[2] == nbPoints.ToString());
                        valAuxRep[2] = nbPoints.ToString();
                        break;

                    case 3: //on conserve le nombre de points donc on change les autres paramètres
                        
                        do
                        {
                            int rF = r.Next(1, 4);

                            switch (rF)
                            {
                                case 1:
                                    forme = "Rectangle";
                                    break;
                                case 2:
                                    forme = "Rond";
                                    break;
                                case 3:
                                    forme = "Triangle";
                                    break;
                            }
                        }
                        while (valAuxRep[0] == forme);
                        valAuxRep[0] = forme;

                        do
                        {
                            int rC = r.Next(1, 4);
                            switch (rC)
                            {
                                case 1:
                                    couleur = "Blue";
                                    break;
                                case 2:
                                    couleur = "Yellow";
                                    break;
                                case 3:
                                    couleur = "Red";
                                    break;
                            }
                        }
                        while (valAuxRep[1] == couleur);
                        valAuxRep[1] = couleur;
                        break;
                }
            }
            #endregion
            #region traitement première image
            else 
            {
                            
                            int rF = r.Next(1, 4);

                            switch (rF)
                            {
                                case 1:
                                    forme = "Rectangle";
                                    break;
                                case 2:
                                    forme = "Rond";
                                    break;
                                case 3:
                                    forme = "Triangle";
                                    break;
                            }
                        
                        valAuxRep[0] = forme;
                       

                        
                            int rC = r.Next(1, 4);
                            switch (rC)
                            {
                                case 1:
                                    couleur = "Blue";
                                    break;
                                case 2:
                                    couleur = "Yellow";
                                    break;
                                case 3:
                                    couleur = "Red";
                                    break;
                            }
                        
                        valAuxRep[1] = couleur;
                       
                     
                            int rP = r.Next(0, 5);
                            nbPoints = rP;
                        
                        valAuxRep[2] = nbPoints.ToString();
                        
     
                }

            createColoredShape(couleur, forme, form);
            createPoint(nbPoints, form);
            #endregion 
            valAuxRep[3] = conserve.ToString();
            return valAuxRep;
           

        }
    }
}