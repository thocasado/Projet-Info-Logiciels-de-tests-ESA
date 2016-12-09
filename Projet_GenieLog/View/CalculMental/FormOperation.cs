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
        // Au lieu de message Box, dire si c'est juste ou faux avec un label direct sur le form.
        //Sauvegarder le taux de résultat; valider avec entrée
        //Ameliorer affichage
        string result;
        int cptBonneRep = 0;
        int compteurCalcul = 0;
        int temps_difficulte = 5000;
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
                compteurCalcul++;
                count.Text = compteurCalcul.ToString() + "/10";
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
           
            if (saisieResultat.Text == result)
            {
                MessageBox.Show("Juste!");
                cptBonneRep++;

            }
            else
            {
                MessageBox.Show("Faux\n" + result);
            }
            if (compteurCalcul != 10)
            {
                lancerTest();
            }
            else
            {
                MessageBox.Show("Vous avez eu un total de" + cptBonneRep + "/10 !");
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
