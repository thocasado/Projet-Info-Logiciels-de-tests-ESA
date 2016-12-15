using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_GenieLog
{
    public partial class MyMessageBox : Form
    {
        string[] bonneReponse = new string[3];//on définit de base avec 3réponses; s'il y en a 4 il sera redéfini
        string[] repUtilisateur = new string[3];
        int cptBonneReponse;
        static int cptBonneReponseTotal = 0;
        static int cptNombreFormeTotal = 0;
        int cptTest = View.FormPerception.cptTest;
        int tempsAffichage = 1500;

        public MyMessageBox()
        {
            InitializeComponent();
            verifLB.Visible = false;
        }

        public void reponseVisible()
        {
            if (Perception.nbFormeVoulue == 3)
            {
                lettre4LB.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                lettre4LB.Visible = true;
                textBox4.Visible = true;
                bonneReponse = new string[4];
                repUtilisateur = new string[4];
            }
            validButton.Enabled = true;
        }

        public void implementationLabel()
        {

            count.Text = cptTest.ToString() + "/10";
            lettre1LB.Text = Perception.tableauFormeVoulue[0].lettre;
            lettre2LB.Text = Perception.tableauFormeVoulue[1].lettre;
            lettre3LB.Text = Perception.tableauFormeVoulue[2].lettre;
            if (Perception.nbFormeVoulue == 4)
            {
                lettre4LB.Text = Perception.tableauFormeVoulue[3].lettre;
            }

            for (int i = 0; i < bonneReponse.Length; i++)
            {
                bonneReponse[i] = Perception.tableauFormeVoulue[i].valeur.ToString();
            }
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            cptBonneReponse = 0;
            repUtilisateur[0] = textBox1.Text;
            repUtilisateur[1] = textBox2.Text;
            repUtilisateur[2] = textBox3.Text;
            if (Perception.nbFormeVoulue == 4)
            {
                repUtilisateur[3] = textBox4.Text;
            }
            for (int cpt = 0; cpt < bonneReponse.Length; cpt++)
            {
                if (repUtilisateur[cpt] == bonneReponse[cpt])
                {
                    cptBonneReponse++;
                }
            }

            verifLB.Visible = true;
            verifLB.Text = "Nombre de bonne(s) réponse(s) :\n" + cptBonneReponse.ToString() + "/" + Perception.nbFormeVoulue;
            timerAfficheResultat.Interval = tempsAffichage;
            timerAfficheResultat.Start();
            cptNombreFormeTotal += Perception.nbFormeVoulue;
            cptBonneReponseTotal += cptBonneReponse;
        }
        private void timerAfficheResultat_Tick(object sender, EventArgs e)
        {
            validButton.Enabled = false;
            timerAfficheResultat.Stop();
            verifLB.Visible = false;
            this.SetVisibleCore(false);

            if (cptTest != 10)
            {
                View.FormPerception fp = new View.FormPerception();
                fp.ShowDialog();
            }
            else
            {

                MessageBox.Show("Vous avez eu un score total de " + 100 * cptBonneReponseTotal / cptNombreFormeTotal + "%");
                string resultatFinal = 100 * cptBonneReponseTotal / cptNombreFormeTotal + "%";
                Sauvegarde.rPerception = resultatFinal;
                this.Close();
                View.FormPerception.cptTest = 1;
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)//valide les réponses
            {
                if (validButton.Enabled)
                {
                    validButton_Click(null, null);
                }
            }
            if (e.KeyCode == Keys.Tab)//permet de passer d'un textBox à l'autre en appuyant sur tab (raccourci usuel)
            {

                Cursor.Position = GetNextControl(this, true).Location;//passe d'un controle à l'autre en récupérant la position du textBox actuel. Le
                                                                      //true permet d'accèder à l'élement suivant, false élément précédent
            }
        }
    }
}
