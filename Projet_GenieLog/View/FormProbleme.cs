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

        int cptTest = 0;//compte à quel test on est
        int cptBonneRep = 0;//compte le nombre de bonnes réponses
        
        Probleme [] pbm;//tableau permettant de récupérer les problèmes sélectionnés
        string bonneRep;
        string repUtilisateur;

        
       
        
        
        
        
        public FormProbleme(string matiere)
        {
            InitializeComponent();
            pbm = Probleme.selectionPbm(matiere, MainMenu.difficile);
            lancerTest();
            
        }

        public void lancerTest()
        {
            
            groupBoxRb.Controls.Add(rbChoix1);
            groupBoxRb.Controls.Add(rbChoix2);
            groupBoxRb.Controls.Add(rbChoix3);
            groupBoxRb.Controls.Add(rbChoix4);
            string image = "Images/";//on accede au dossier image du Debug
            image += pbm[cptTest]._image;//on lui rajoute le nom de l'image à afficher
            pictureBox.Image = new Bitmap(image);
            labelConsigne.Text = pbm[cptTest]._consigne;
            rbChoix1.Text = pbm[cptTest]._choix1;
            rbChoix2.Text = pbm[cptTest]._choix2;
            rbChoix3.Text = pbm[cptTest]._choix3;
            rbChoix4.Text = pbm[cptTest]._choix4;
            bonneRep= pbm[cptTest]._bonneRep;
            cptTest++;
            count.Text=cptTest.ToString();
            

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
                cptBonneRep++;

            }
            else
            {
                MessageBox.Show("Faux\n" + bonneRep);
            }
            if (cptTest != 10)
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
