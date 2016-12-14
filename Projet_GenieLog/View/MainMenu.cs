﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GenieLog
{
    public partial class MainMenu : Form
    {
       
        public static bool difficile { get; set; }
        static int compteur = 0;
        public MainMenu()
        {
            InitializeComponent();
            timerChargementMenu.Interval = 5000;
            timerChargementMenu.Start();
            groupBoxDifficulte.Controls.Add(radio_facile);
            groupBoxDifficulte.Controls.Add(radio_difficile);
            nomUtilisateurTB.Text = Sauvegarde.nomUtilisateur;
            rPerceptionLB.Text = Sauvegarde.rPerception;
            rConcentrationLB.Text = Sauvegarde.rConcentration;
            rCmLB.Text = Sauvegarde.rCm;
            rPhysiqueLB.Text = Sauvegarde.rPhysique;
            rMathsLB.Text = Sauvegarde.rMaths;
            
           
            
        }

        public void loadTest(object sender, EventArgs eventargs)
        {
            switch (((Button)sender).Name)
            {
                case "btnPerception":
                    View.FormPerception p = new View.FormPerception();
                    View.FormPerception.cptTest = 1;// cpt test étant static, si on revient au menu puis relance le test de perception, cptTest garde sa valeur précédente;Il faut donc le réinitialiser
                    p.Show();
                    break;
                case "btnConcentration":
                    View.FormConcentration con = new View.FormConcentration();
                    con.Show();
                    break;
                case "btnCalcul":
                    View.FormCalculMental cm = new View.FormCalculMental();
                    cm.Show();
                    break;
                case "btnMaths":
                    View.FormProbleme pbM = new View.FormProbleme("Mathématiques");
                    pbM.Show();
                    break;
                case "btnPhysique":
                    View.FormProbleme pbPhy = new View.FormProbleme("Physique");
                    pbPhy.Show();
                    break;

            }
        }
       
        private void radio_difficile_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_difficile.Checked == true)
            {
                difficile = true;
            }
            else
            {
                difficile = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sauvegarde.nomUtilisateur = nomUtilisateurTB.Text;
            pictureBoxChecked.Visible = false;
            RaffraichissementMenuTimer.Start();
        }

        private void nomUtilisateurTB_TextChanged(object sender, EventArgs e)
        {
            pictureBoxChecked.Visible = true;
            RaffraichissementMenuTimer.Stop();
            timerRentrerNom.Start();
        }

        private void RaffraichissementMenuTimer_Tick(object sender, EventArgs e)
        {
            MainMenu_Load(null, null);

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RaffraichissementMenuTimer.Start();
            nomUtilisateurTB.Text = Sauvegarde.nomUtilisateur;
            rPerceptionLB.Text = Sauvegarde.rPerception;
            rConcentrationLB.Text = Sauvegarde.rConcentration;
            rCmLB.Text = Sauvegarde.rCm;
            rPhysiqueLB.Text = Sauvegarde.rPhysique;
            rMathsLB.Text = Sauvegarde.rMaths;
            compteur++;
            
          
        }

        private void timerRentrerNom_Tick(object sender, EventArgs e)
        {
            timerRentrerNom.Stop();
            MainMenu_Load(null, null);
        }

        private void timerChargementMenu_Tick(object sender, EventArgs e)
        {
            pictureBoxAccueil.Visible = false;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
            "Souhaitez-vous vraiment fermer l'application ?",
                "Confirmez la fermeture",
            MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
