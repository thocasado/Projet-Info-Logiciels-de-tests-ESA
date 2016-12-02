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
        //reste à prendre en compte difficulte, générer formes, points, couleurs, récuperer toutes les infos et bonne rép le tout mis dans un xml
        int compteur =0;//compte à quel test on est d'une serie
        int cptSerie=1;//compte à quelle serie on est
        int cpt = 0;//compte le nombre de bonnes réponses dans une série
        int cptTotal=0;//compte le nombre de bonnes réponses dans toute les séries mélangées

        string bonneRep="button3";
        string repUtilisateur;

        public FormConcentration()
        {
            InitializeComponent();
            lancerTest();
        }

        


       public void lancerTest()
        {

            groupBoxButton.Controls.Add(button1);
            groupBoxButton.Controls.Add(button2);
            groupBoxButton.Controls.Add(button3);
            
            //labelConsigne.Text = pbm[compteur]._consigne;
            //bonneRep = pbm[compteur]._bonneRep;
            compteur++;
            count.Text = compteur.ToString()+ "/10";
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
                    MessageBox.Show("Fin de l'exercice. Vous avez eu un total de "+cptTotal +"/ 15");
                    this.Close();
                }
            }

        
        }
    }
}
