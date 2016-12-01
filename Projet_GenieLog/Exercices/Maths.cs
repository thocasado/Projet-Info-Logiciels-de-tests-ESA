using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace Projet_GenieLog
{
    public class Maths : Exercices
    {
        public int _id { get; set; }
        public string _consigne { get; set; }
        public string _choix1 { get; set; }
        public string _choix2 { get; set; }
        public string _choix3 { get; set; }
        public string _choix4 { get; set; }
        public string _bonneRep { get; set; }
        //image
        

        public Maths(int id, string consigne, string c1, string c2, string c3, string c4, string br/*,image image*/)
        {
            _id = id;
            _consigne = consigne;
            _choix1 = c1;
            _choix2 = c2;
            _choix3 = c3;
            _choix4 = c4;
            _bonneRep = br;
        }

        public  static Maths[]  selectionPbm()
        {

            int nbDePbmTotal=20;
            int nbDePbmAselectionner=10;
#region Deserialisation
            Maths[] pbmMaths = new Maths[nbDePbmTotal];
            XDocument doc = XDocument.Load("maths.xml");
            var pbms = doc.Descendants("problemesMaths").First();
            var pbm = pbms.Descendants("pbm");
#endregion

            foreach (var p in pbm)
            {
                pbmMaths[(int)p.Attribute("id")-1] = new Maths((int)p.Attribute("id"), (string)p.Attribute("consigne"), (string)p.Attribute("choix1"), (string)p.Attribute("choix2"), (string)p.Attribute("choix3"), (string)p.Attribute("choix4"), (string)p.Attribute("bonnereponse"));
            }
            Random r=new Random();
            Maths [] selectionPbm= new Maths[nbDePbmAselectionner];
            int cpt=0;
            int [] indiceDejaTombe=new int [nbDePbmTotal];
            for (int i = 0; i < nbDePbmAselectionner; i++)
            {

                int indice = r.Next(0, nbDePbmTotal);
                for (int j = 0; j <nbDePbmTotal ; j++)
                {
                    if (indice == indiceDejaTombe[j])
                    {
                        cpt++;
                    }
                }
                if (cpt == 0)
                {
                    selectionPbm[i] = pbmMaths[indice];
                    indiceDejaTombe[i] = indice;
                }
                else
                {
                        i--;//on reste à cet indice la du tableau de selection, on passe pas au suivant si on remplit pas le tableau
                        cpt = 0;   
                }
            }
            return selectionPbm;


        }

    }
}