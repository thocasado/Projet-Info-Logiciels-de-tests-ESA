using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Projet_GenieLog
{
    class Sauvegarde
    {
        public static string nomUtilisateur="";
        public static string rPerception = "...%";
        public static string rConcentration = "...%";
        public static string rCm = "...%";
        public static string rMaths= "...%";
        public static string rPhysique = "...%";

        public Sauvegarde(string nU, string rP, string rC, string rO, string rM, string rPh)
        {
            nomUtilisateur=nU;
            rPerception=rP;
            rConcentration=rC;
            rCm=rO;
            rMaths=rM;
            rPhysique=rPh;
        }

        public override string ToString()
        {
            string ch = "<NomUtilisateur>" + nomUtilisateur + "\n<Resultats>\n<ResultatConcentration>" + rConcentration + "</ResultatConcentration>" +
                        "\n<ResultatPerception>" + rPerception + "</ResultatPerception>" + "\n<ResultatCalcul>" + rCm + "</ResultatCalcul>" +
                        "\n<ResultatMaths>" + rMaths + "</ResultatMaths>" + "\n<ResultatPhysique>" + rPhysique + "</ResultatPhysique>\n</Resultats>\n</NomUtilisateur>";
            return ch;
        }
        

        public static void SauvegardeXML(Sauvegarde s)
        {

            using (System.IO.StreamWriter nouvelleSauvegarde =
           new System.IO.StreamWriter("sauvegarde.xml", true))
            {
                nouvelleSauvegarde.WriteLine(s);
            }
                
        }

    }
}
