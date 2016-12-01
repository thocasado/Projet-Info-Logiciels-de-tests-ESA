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
    public partial class FormMaths : Form
    {
        int compteur = 0;//compte à quel test on est
        int cpt = 0;//compte le nombre de bonnes réponses
        Maths[] pbmMaths = Maths.selectionPbm();
        string bonneRep;
        string repUtilisateur;
        
        
   
   
        

        public FormMaths()
        {
            InitializeComponent();
            lancerTest();
            
        }

        public void lancerTest()
        {

            groupBoxRb.Controls.Add(rbChoix1);
            groupBoxRb.Controls.Add(rbChoix2);
            groupBoxRb.Controls.Add(rbChoix3);
            groupBoxRb.Controls.Add(rbChoix4);
            labelConsigne.Text = pbmMaths[compteur]._consigne;
            rbChoix1.Text = pbmMaths[compteur]._choix1;
            rbChoix2.Text = pbmMaths[compteur]._choix2;
            rbChoix3.Text = pbmMaths[compteur]._choix3;
            rbChoix4.Text = pbmMaths[compteur]._choix4;
            bonneRep= pbmMaths[compteur]._bonneRep;
            compteur++;
            count.Text=compteur.ToString();
            

        }

        private void validButton_Click(object sender, EventArgs e)
        {
            afficheResultat();
        }

        private void afficheResultat()
        {
            foreach (RadioButton rb in groupBoxRb.Controls)
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
            
        }

        
        

        


    }
}
