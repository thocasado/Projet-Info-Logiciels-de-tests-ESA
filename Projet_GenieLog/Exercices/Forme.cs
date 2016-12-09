using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            public Forme()
            {

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

            public override string ToString()
            {
                string ch = "forme:" + forme + " color:" + couleur + " value:" + valeur + " letter: " + lettre;
                return ch;
            }
        }



    
}
