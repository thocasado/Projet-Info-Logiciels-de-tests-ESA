using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_GenieLog.View.CalculMental
{
    public partial class FormOperation : Form
    {
        // mettre timer pour fermer messageBox et passer au calcul suivant(geré au clic pour le moment) 
        //Sauvegarder le taux de résultat; valider avec entrée
        //Ameliorer affichage
        string result;
        int cpt = 0;//compteur de bonne réponse; 
        int compteur = 0; // Compteur du nombre de calcul effectué 
        int temps_difficulte = 5000; // temps de la difficulte difficile en ms
        //int temps_affichage = 3000; //temps affichage resultat
        string _type;
        bool _difficile;
        
            public FormOperation(string type, bool difficile)
            {
                InitializeComponent();
                _type = type;
                _difficile = difficile;
                lancerTest();

            
            }

            private void lancerTest()
            {
                compteur++;
                count.Text = compteur.ToString() + "/10";
                saisieResultat.Clear();
                labelSigne.Text = _type;
                Random r = new Random();
                int a=0; 
                int b=0;

                switch (_type)
                {
                    case "+":
                        a = r.Next(100, 1000);
                        b = r.Next(100, 1000);
                        result = (a + b).ToString();
                        break;
                    case "-":
                        b = r.Next(10, 1000);
                        a = r.Next(b + 1, 1000);
                        result = (a - b).ToString();
                        break;
                    case "x":
                        a = r.Next(10, 100);
                        b = r.Next(1, 10);
                        result = (a * b).ToString();
                        break;
                    case "/":
                        a = r.Next(10, 100);
                        b = r.Next(1, 10);

                        int aux;//stockage temporaire du resultat
                        double reste = a % b;
                        if (reste > (b / 2))
                        {
                            aux = (a / b) + 1;
                        }
                        else
                        {
                            aux = a / b;
                        }
                        result = aux.ToString();
                        break;
                }
                
                        
                
                chiffre1.Text = a.ToString();
                chiffre2.Text = b.ToString();


                if (_difficile)
                {
                    timerDifficile.Interval = temps_difficulte;
                    timerDifficile.Start();
                }

            }
        private void validButton_Click(object sender, EventArgs e)
        {
            resultatTest();
            
        }


        private void timerDifficile_Tick(object sender, EventArgs e)
        {
            resultatTest();
        }
         

        private void resultatTest()
        {
            timerDifficile.Stop();
           /* timerAfficheResultat.Interval = temps_affichage;
            timerAfficheResultat.Start();*/
            if (saisieResultat.Text == result)
            {
                MessageBox.Show("Juste!");
                cpt++;

            }
            else
            {
                MessageBox.Show("Faux\n" + result);
            }
            if (compteur != 10)
            {
                lancerTest();
            }
            else
            {
                MessageBox.Show("Vous avez eu un total de" + cpt + "/10 !");
                this.Close();
            }
            
        }

        /*private void timerAfficheResultat_Tick(object sender, EventArgs e)
        {
            //impossible de fermer une messageBox sans cliquer sur ok -> mettre affichage juste ou faux dans un label direct
            //sur l'interface peut être mieux, ou alors on laisse au click avec messageBox, à réfléchir.
            lancerTest(difficile);
        }*/
    

        

        


        
        
      

      

        
    }
}
