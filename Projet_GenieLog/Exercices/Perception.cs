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
    
    public class Perception 
    {
        public static Forme[] tableauFormeVoulue;
        public static int nbFormeVoulue;
        public static int[,] rndNumbersTab = new int[3, 4];
        public string _consigne { get; set; }
        public string _forme { get; set; }
        public string _couleur { get; set; }

        public Perception(string consigne, string forme, string couleur)
        {
            _consigne = consigne;
            _forme = forme;
            _couleur = couleur;
        }

        public static Perception selectionRegle()
        {
            
            #region Deserialisation
            
            List<Perception> regles = new List<Perception>();
            XDocument doc = XDocument.Load("rulePerception.xml");
            var ensembleRegles = doc.Descendants("Regles").First();
            var regle = ensembleRegles.Descendants("regle");

            foreach (var r in regle)
            {
                regles.Add(new Perception((string)r.Attribute("consigne"), (string)r.Attribute("forme"), (string)r.Attribute("couleur")));
            }
            int nbDeRegleTotal = regles.Count();

            #endregion
            Random rnd = new Random();
            int a = rnd.Next(0, nbDeRegleTotal);
            return regles[a];

        }
        
        public static void generationTableauValeur() // méthode static pour pouvoir l'appeler dans FormPerception
        {
            Random rnd = new Random();

            for (int i= 0; i<3; i++)
            {
                for (int j=0; j<4; j++)
                {
                    rndNumbersTab[i, j] = rnd.Next(0, 10);
                }
            }

        }

        

        public static Forme[,] selectionFormes(Perception regle)
        {
            Forme [,] tableauForme = new Forme[3, 4];
            Random rnd = new Random();
            string[,] arrayLetters = new string[3, 4] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" }, { "I", "J", "K", "L" } };
            string formeVoulue = regle._forme;
            string couleurVoulue = regle._couleur;
            string couleur="";
            string forme="";
            int largeur = 50;
            int hauteur = 50;
           

            //on place aléatoirement les 3 ou 4 formes à reperer
               nbFormeVoulue = rnd.Next(3, 5);
               int cptFormeVoulue = 0;
               tableauFormeVoulue=new Forme[nbFormeVoulue];

               while(cptFormeVoulue<nbFormeVoulue)
               {
                   
                   int i=rnd.Next(0,3);
                   int j=rnd.Next(0,4);
                   if (tableauForme[i, j] == null)//on crée une nouvelle forme qu'a un emplacement ou il n'y en a pas déjà
                   {
                       tableauForme[i, j] = new Forme(couleurVoulue, formeVoulue,rndNumbersTab[i,j], 25 + 105 * j, 30 + 95 * i, arrayLetters[i, j],largeur,hauteur);
                       tableauFormeVoulue[cptFormeVoulue] = tableauForme[i, j];
                       cptFormeVoulue++;//on change d'indice que si on crée une nouvelle forme
                   }
                   

                   
               }

            //on place toutes les autres
               for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {
                       if (tableauForme[i, j] == null)// on ne remplit le tableau que s'il est vide, soit s'il y a pas de forme voulue deja à cette position
                       {
                           
                           int rndCouleur = rnd.Next(1, 3); //1=Bleu, 2=jaune
                           int rndForme = rnd.Next(1, 3);
                           
                           switch (rndCouleur)
                           {
                               case 1:
                                   couleur = "Blue";
                                   break;
                               case 2:
                                   couleur = "Yellow";
                                   break;
                           }
                           switch (rndForme)
                           {
                               case 1:
                                   forme = "Rectangle";
                                   break;
                               case 2:
                                   forme = "Rond";
                                   break;
                           }
                           if (couleur != couleurVoulue)
                           {
                               tableauForme[i, j] = new Forme(couleur, forme, rndNumbersTab[i,j], 25 + 105 * j, 30 + 95 * i,arrayLetters[i,j],largeur,hauteur);
                           }
                           else
                           {
                               if (forme != formeVoulue)
                               {
                                   tableauForme[i, j] = new Forme(couleur, forme, rndNumbersTab[i,j], 25 + 105 * j, 30 + 95 * i,arrayLetters[i,j],largeur,hauteur);
                               }
                               else// on ne crée aucune forme car c'était une "formeVoulue" qui a été tiré donc on passe pas à la colonne suivante
                               {
                                   j--;   
                               }
                           }
                       }
                   }
               }
               return tableauForme;                                                       
            
      }//probleme boucle while, propose que 2 formes voulues parfois


        public static void dessineNombres(PaintEventArgs e)// dessine les chiffres aléatoirement 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    e.Graphics.DrawString(rndNumbersTab[i, j].ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(43.0F + 105.0F * j, 43.0F + 95.0F * i));

                }
            }
        }


        
    }

}