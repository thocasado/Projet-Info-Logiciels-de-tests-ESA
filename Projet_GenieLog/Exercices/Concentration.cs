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
    public class Concentration 
    {
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
            
            #region Deserialisation
            
            List<Concentration> regles = new List<Concentration>();
            XDocument doc = XDocument.Load("ruleConcentration.xml");
            var ensembleRegles = doc.Descendants("Regles").First();
            var regle = ensembleRegles.Descendants("regle");

            foreach (var r in regle)
            {
                regles.Add(new Concentration((string)r.Attribute("consigne"), (string)r.Attribute("boutonForme"), (string)r.Attribute("boutonNbP"), (string)r.Attribute("boutonCouleur")));
            }
            int nbDeRegleTotal = regles.Count();

            #endregion
            Random rnd = new Random();
            int a= rnd.Next(0, nbDeRegleTotal);
            return regles[a];

        }

        public static string[] selectionForme(int compteur,string []valAuxRep, Form form) //le tableau valAuxRep contient les paramètres de la forme précédente et la valeur du paramètre conservé
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

            //createColoredShape(couleur, forme, form);
            //createPoint(nbPoints, form);
            #endregion 
            valAuxRep[3] = conserve.ToString();
            return valAuxRep;          

        }
    }
}