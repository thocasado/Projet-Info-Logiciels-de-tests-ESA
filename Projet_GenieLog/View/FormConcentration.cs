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
        int cptTest = 0;
        int cptSerie = 1;
        int cptBonneRep = 0;
        int cptTotalBonneRep = 0;
        Concentration regle;// Nous permet de récuperer la consigne et le bouton correspondant à la bonne réponse(1 si forme conservée, 2 si couleur,3 si nbPoints)
        string bonneRep;
        string repUtilisateur;
        string[] valeurs = new string[4];//valeurs[0]=formePrécedente, valeurs[1]=couleurPrécedente, valeurs[2]=nbPoitnsPrécédente, valeurs[3]=paramètreConservé
        bool _difficile;
        int tempsDifficulte = 5000; //on définit ici l'intervalle de temps entre chaque écran 
        Forme f;

        public FormConcentration()
        {
            InitializeComponent();
            regle = Concentration.selectionRègle();
            _difficile = MainMenu.difficile;
            string consigne = regle._consigne;
            if (_difficile)
            {
                consigne+="\nVous avez "+tempsDifficulte+ "pour choisir le bon bouton.";
            }
            consigne += "\nAppuyer sur OK quand vous êtes prêt.";

            MessageBox.Show(consigne);
            lancerTest();
        }

        public void lancerTest()
        {
            Invalidate();//permet d'effacer les dessins précédents pour éviter une superposition des formes
            bonneRep = "button";//on va ajouter l'indice correspondant au bouton attendu 
            groupBoxButton.Controls.Add(button1);
            groupBoxButton.Controls.Add(button2);
            groupBoxButton.Controls.Add(button3);

            labelConsigne.Text = regle._consigne;
            cptTest++;
            count.Text = cptTest.ToString() + "/5";
            if (cptTest == 1)
            {
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
            }

            valeurs = Concentration.selectionForme(cptTest, valeurs, this);// la génération des dessins se fait dans OnPaint, on récupère ici les paramètres necessaires
            f = new Forme(valeurs[1], valeurs[0], 129, 199,100,100);

            if (cptTest != 1)
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
                cptBonneRep++;
            }
            if (cptTest != 5)
            {
                lancerTest();
            }
            else
            {
                cptTotalBonneRep += cptBonneRep;
                if (cptSerie != 3)
                {
                    MessageBox.Show("Vous avez eu un total de" + cptBonneRep*20 + "% de bonnes réponses à la serie " + cptSerie + "\n Prêt pour la suivante ?");
                    cptTest = 0;
                    cptSerie++;
                    cptBonneRep = 0;
                    if (_difficile)
                    {
                        regle = Concentration.selectionRègle();
                        MessageBox.Show(regle._consigne);
                    }
                    lancerTest();

                }
                else
                {
                    MessageBox.Show("Vous avez eu un total de" + cptBonneRep + "/5 ! à la serie " + cptSerie);
                    MessageBox.Show("Fin de l'exercice. Vous avez eu un total de " + 100 * cptTotalBonneRep / 15 + " % de bonnes réponses !");
                    string resultatFinal = 100*cptTotalBonneRep / 15 + "%";
                    Sauvegarde.rConcentration = resultatFinal;
                    this.Close();
                }
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            int nbpoint = int.Parse(valeurs[2]);
            Forme.creationFormeColorée(f, this);
            Forme.creationPoint(nbpoint, this);
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
