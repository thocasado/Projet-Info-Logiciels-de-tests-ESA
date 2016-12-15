using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace Projet_GenieLog
{
    public class Probleme 
    {
        public int _id { get; set; }
        public string _consigne { get; set; }
        public string _choix1 { get; set; }
        public string _choix2 { get; set; }
        public string _choix3 { get; set; }
        public string _choix4 { get; set; }
        public string _bonneRep { get; set; }
        public string _image { get; set; }               

        public Probleme(int id, string consigne, string c1, string c2, string c3, string c4, string br,string image)
        {
            _id = id;
            _consigne = consigne;
            _choix1 = c1;
            _choix2 = c2;
            _choix3 = c3;
            _choix4 = c4;
            _bonneRep = br;
            _image = image;
        }

        public  static Probleme[]  selectionPbm(string matiere,bool difficile)
        {
            
            int nbDePbmAselectionner=10;
#region Deserialisation
            
            List<Probleme> problemes = new List<Probleme>();
            
            XDocument doc = XDocument.Load("probleme.xml");
            var ensemblePbm = doc.Descendants("Problemes").First();
            var ensemblePbms = ensemblePbm.Descendants("problemesPhysique");//on initialise ensemblePbms avec les problemes de physiques
            
            if (matiere == "Mathématiques")//si la matiere est mathématique on change pbms, sinon ca reste physique
            {
                ensemblePbms= ensemblePbm.Descendants("problemesMaths");
            }
            var pbmsDifficulte = ensemblePbms.Descendants("facile");// on initialise pbmsDifficulte avec les problemes de physiques/maths faciles
            if (difficile)
            {
                pbmsDifficulte = ensemblePbms.Descendants("difficile");
            }
                var pbm = pbmsDifficulte.Descendants("pbm");
            



            foreach (var p in pbm)
            {
                problemes.Add(new Probleme((int)p.Attribute("id"), (string)p.Attribute("consigne"), (string)p.Attribute("choix1"), (string)p.Attribute("choix2"), (string)p.Attribute("choix3"), (string)p.Attribute("choix4"), (string)p.Attribute("bonnereponse"),(string)p.Attribute("image")));
            }
            int nbDePbmTotal = problemes.Count;
#endregion

            Random r=new Random();
            Probleme [] selectionPbm= new Probleme[nbDePbmAselectionner];
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
                    selectionPbm[i] = problemes[indice];
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