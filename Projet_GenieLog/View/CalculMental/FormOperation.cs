﻿using System;
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
        int tempsAffichage = 2000;
        string _type;
        bool _difficile;
        int[] valeurs;//valeurs[0] = chiffre1; valeurs[1]=chiffre2; valeurs[2]=resultat
        
            public FormOperation(string type, bool difficile)
            {
                InitializeComponent();
                _type = type;
                _difficile = difficile;
                lancerTest();
                verifLB.Visible = false;

            
            }

            private void lancerTest()
            {
                compteurCalcul++;
                count.Text = compteurCalcul.ToString() + "/10";
                saisieResultat.Clear();
                labelSigne.Text = _type;
                valeurs = Operation.realisationCalcul(_type);  
                
                chiffre1.Text = valeurs[0].ToString();
                chiffre2.Text = valeurs[1].ToString();
                result = valeurs[2].ToString();


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
            verifLB.Visible = true;
            verifLB.Font = new Font("Calibri", 12);
            
            if (saisieResultat.Text == result)
            {
                
                verifLB.ForeColor = Color.Green;
                verifLB.Text = "Juste !";
                cptBonneRep++;

            }
            else
            {
                verifLB.ForeColor = Color.Red;
                verifLB.Text = "Faux\n" + result;
            }
            timerAfficheResultat.Interval = tempsAffichage;
            timerAfficheResultat.Start();
            
            
        }

        private void timerAfficheResultat_Tick(object sender, EventArgs e)
        {
            verifLB.Visible = false;
            timerAfficheResultat.Stop();
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

       
    

        

        


        
        
      

      

        
    }
}
