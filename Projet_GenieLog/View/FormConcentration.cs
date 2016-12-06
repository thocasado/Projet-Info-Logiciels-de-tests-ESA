using System;
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

        //Ameliorer affichage + régler position des points 
        int compteur = 0;//compte à quel test on est d'une serie
        int cptSerie = 1;//compte à quelle serie on est
        int cpt = 0;//compte le nombre de bonnes réponses dans une série
        int cptTotal = 0;//compte le nombre de bonnes réponses dans toute les séries mélangées
        Concentration regle;// Nous permet de récuperer la consigne et le bouton correspondant à la bonne réponse(1 si forme conservée, 2 si couleur,3 si nbPoints)
        string bonneRep;
        string repUtilisateur;
        string[] valeurs = new string[4];//valeurs[0]=formePrécedent, valeurs[1]=couleur, valeurs[2]=nbPoitns, valeurs[3]=paramètreConservé
        bool _difficile;
        int tempsDifficulte = 5000; //on définit ici l'intervalle de temps entre chaque écran 

        public FormConcentration(bool difficile)
        {
            InitializeComponent();
            regle = Concentration.selectionRègle();
            _difficile = difficile;
            MessageBox.Show(regle._consigne);
            lancerTest();
        }




        public void lancerTest()//voir pourquoi ca ne dessine pas au premier tour 
        {
            Invalidate();//permet d'effacer les dessins précédents pour éviter une superposition des formes
            bonneRep = "button";//on va ajouter l'indice correspondant à BoutonReponse
            groupBoxButton.Controls.Add(button1);
            groupBoxButton.Controls.Add(button2);
            groupBoxButton.Controls.Add(button3);

            labelConsigne.Text = regle._consigne;
            compteur++;
            count.Text = compteur.ToString() + "/5";
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

            valeurs = Concentration.generateShape(compteur, valeurs, this);// la génération des dessins se fait dans OnPaint, on récupère ici les paramètres necessaires




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

            





        }





        private void button_Click(object sender, EventArgs e)
        {
            repUtilisateur = ((Button)(sender)).Text;
            afficheResultat();


        }

        private void afficheResultat()
        {
            timerConcentration.Stop();
            if (bonneRep == repUtilisateur)
            {
                cpt++;
            }
            if (compteur != 5)
            {
                lancerTest();
            }
            else
            {
                cptTotal += cpt;
                if (cptSerie != 3)
                {
                    MessageBox.Show("Vous avez eu un total de" + cpt + "/5 ! à la serie " + cptSerie + "\n Prêt pour la suivante ?");
                    compteur = 0;
                    cptSerie++;
                    cpt = 0;
                    lancerTest();

                }
                else
                {
                    MessageBox.Show("Vous avez eu un total de" + cpt + "/5 ! à la serie " + cptSerie);
                    MessageBox.Show("Fin de l'exercice. Vous avez eu un total de " + cptTotal + "/ 15");
                    this.Close();
                }
            }

        }



        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            int nbpoint = int.Parse(valeurs[2]);
            Concentration.createColoredShape(valeurs[1], valeurs[0], this);
            Concentration.createPoint(nbpoint, this);
            if (_difficile)
            {
                timerConcentration.Interval = tempsDifficulte;
                timerConcentration.Start();
            }

        }



        private void timerConcentration_Tick(object sender, EventArgs e)
        {
            afficheResultat();

        }
    }
}
