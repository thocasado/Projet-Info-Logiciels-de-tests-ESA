﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_GenieLog.View
{
    public partial class FormConcentration : Form
    {
        //reste à prendre en compte difficulte, traitement marche parfaitement, génération de dessins plantent, chercher commment effacer les dessins de l'image précédente
        int compteur =0;//compte à quel test on est d'une serie
        int cptSerie=1;//compte à quelle serie on est
        int cpt = 0;//compte le nombre de bonnes réponses dans une série
        int cptTotal=0;//compte le nombre de bonnes réponses dans toute les séries mélangées
        Concentration regle;// Nous permet de récuperer la consigne et le bouton correspondant à la bonne réponse(1 si forme conservée, 2 si couleur,3 si nbPoints)
        string bonneRep;
        string repUtilisateur;
        string[] valeurs = new string[4];//valeurs[0]=formePrécedent, valeurs[1]=couleur, valeurs[2]=nbPoitns, valeurs[3]=paramètreConservé
       

        public FormConcentration()
        {
            InitializeComponent();
            regle = Concentration.selectionRègle();
            MessageBox.Show(regle._consigne);
            lancerTest();
        }

        


       public void lancerTest()//voir pourquoi ca ne dessine pas au premier tour 
        {
            
            bonneRep = "button";//on va ajouter l'indice correspondant à BoutonReponse
            groupBoxButton.Controls.Add(button1);
            groupBoxButton.Controls.Add(button2);
            groupBoxButton.Controls.Add(button3);
            
            labelConsigne.Text = regle._consigne;
            compteur++;
            count.Text = compteur.ToString()+ "/5";
            if (compteur == 1)
            {
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
            }

            

            valeurs = Concentration.generateShape(compteur,valeurs, this);
            

            if (compteur != 1)
            {
                switch (valeurs[3])
                {
                    case "1"://c'est la forme qui est conservée
                        bonneRep += regle._boutonForme;
                        break;
                    case "2"://c'est la couleur qui est conservée 
                        bonneRep += regle._boutonCouleur;
                        break;
                    case "3"://c'est le nbDePoint 
                        bonneRep += regle._boutonNbPoint;
                        break;
                }
            }
            else
            {
                bonneRep += "3";
            }
            label1.Text = bonneRep;
            MessageBox.Show("Forme: " + valeurs[0] + "\nCouleur: " + valeurs[1] + "\nbPoint: " + valeurs[2]);
                    
           

       

        }

        

       /* private void afficheResultat()
        {
            repUtilisateur=((Button)(sender)).Text;
            foreach (Button b in groupBoxButton.Controls)
            {
                if (rb.Checked == true)
                {
                    repUtilisateur = rb.Text;
                }
            }

            if (repUtilisateur == bonneRep)
            {
                MessageBox.Show("Juste!");
                cpt++;

            }
            else
            {
                MessageBox.Show("Faux\n" + bonneRep);
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

        }*/

        private void button_Click(object sender, EventArgs e)
        {
            repUtilisateur=((Button)(sender)).Text;
            if (bonneRep==repUtilisateur)
            {
                cpt++;
            }
            if(compteur!=5)
            {
                lancerTest();
                

            }
            else
            {
                cptTotal += cpt;
                if(cptSerie!=3)
                {
                    MessageBox.Show("Vous avez eu un total de" + cpt + "/5 ! à la serie "+cptSerie+"\n Prêt pour la suivante ?");
                    compteur=0;
                    cptSerie++;
                    cpt=0;
                    lancerTest();

                }
                else
                {
                    MessageBox.Show("Vous avez eu un total de" + cpt + "/5 ! à la serie " + cptSerie );
                    MessageBox.Show("Fin de l'exercice. Vous avez eu un total de "+cptTotal +"/ 15");
                    this.Close();
                }
            }

        
        }

        /*private void FormConcentration_Paint(object sender, PaintEventArgs p)
        {
           
            
        }*/






    }
}
