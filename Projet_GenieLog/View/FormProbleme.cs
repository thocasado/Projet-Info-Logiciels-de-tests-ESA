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
        string _matiere;
        int tempsAffichage = 2000;
                
        public FormProbleme(string matiere)
        {
            _matiere = matiere;
            InitializeComponent();
            pbm = Probleme.selectionPbm(matiere, MainMenu.difficile);
            MessageBox.Show("Vous allez avoir une série de 10 problèmes de "+_matiere+" sous forme de QCM.\nUne seule réponse est possible à chaque fois.\nAucune limite de temps pour répondre.\nAppuyer sur OK quand vous êtes prêt.");
            lancerTest();
            verifLB.Visible = false;
            
        }

        public void lancerTest()
        {
            validButton.Enabled = true;
            groupBoxRb.Controls.Add(rbChoix1);
            groupBoxRb.Controls.Add(rbChoix2);
            groupBoxRb.Controls.Add(rbChoix3);
            groupBoxRb.Controls.Add(rbChoix4);
            string image = "Images/";//on accede au dossier image du Debug
            image += pbm[cptTest]._image;//on lui rajoute le nom de l'image à afficher
            imgPbm.Image = new Bitmap(image);
            textBoxConsigne.Text = pbm[cptTest]._consigne;
            rbChoix1.Text = pbm[cptTest]._choix1;
            rbChoix2.Text = pbm[cptTest]._choix2;
            rbChoix3.Text = pbm[cptTest]._choix3;
            rbChoix4.Text = pbm[cptTest]._choix4;
            bonneRep= pbm[cptTest]._bonneRep;
            cptTest++;
            count.Text=cptTest.ToString() + "/10";                       

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
            verifLB.Visible = true;
            verifLB.Font = new Font("Calibri", 12);

            if (repUtilisateur == bonneRep)
            {
                verifLB.ForeColor = Color.Green;
                verifLB.Text = "Juste !";
                cptBonneRep++;

            }
            else
            {
                verifLB.ForeColor = Color.Red;
                verifLB.Text = "Faux\n" + bonneRep;
            }
            validButton.Enabled = false;
            timerAfficheResultat.Interval = tempsAffichage;
            timerAfficheResultat.Start();
        }

        private void timerAfficheResultat_Tick(object sender, EventArgs e)
        {
            verifLB.Visible = false;
            timerAfficheResultat.Stop();
            if (cptTest != 10)
            {
                lancerTest();
            }
            else
            {             
                MessageBox.Show("Vous avez eu un total de " + cptBonneRep*10 + "% de bonnes réponses !");
                string resultatFinal = cptBonneRep * 10 + "%";
                if (_matiere == "Physique")
                {
                    Sauvegarde.rPhysique = resultatFinal;

                }
                else
                {
                    Sauvegarde.rMaths = resultatFinal;
                    
                    
                }
                this.Close();
            }
        }

        private void choixReponse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validButton.Enabled == true)
                {
                    validButton_Click(null, null);
                }
            }
        }       
    }
}
