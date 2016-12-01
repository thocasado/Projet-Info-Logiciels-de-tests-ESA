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

    public partial class FormProbleme : Form
    {
        //gerer le cas facile/difficile + ajout image 
        int compteur = 0;//compte à quel test on est
        int cpt = 0;//compte le nombre de bonnes réponses
        
        Probleme [] pbm;
        string bonneRep;
        string repUtilisateur;

        
       
        
        
        
        
        public FormProbleme(string matiere)
        {
            InitializeComponent();
            pbm = Probleme.selectionPbm(matiere);
            lancerTest();
            
        }

        public void lancerTest()
        {
            
            groupBoxRb.Controls.Add(rbChoix1);
            groupBoxRb.Controls.Add(rbChoix2);
            groupBoxRb.Controls.Add(rbChoix3);
            groupBoxRb.Controls.Add(rbChoix4);
            string image = "Images/";//on accede au dossier image du Debug
            image += pbm[compteur]._image;
            pictureBox.Image = new Bitmap(image);
            labelConsigne.Text = pbm[compteur]._consigne;
            rbChoix1.Text = pbm[compteur]._choix1;
            rbChoix2.Text = pbm[compteur]._choix2;
            rbChoix3.Text = pbm[compteur]._choix3;
            rbChoix4.Text = pbm[compteur]._choix4;
            bonneRep= pbm[compteur]._bonneRep;
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
