using System;
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
        public MainMenu()
        {
            InitializeComponent();
            groupBoxDifficulte.Controls.Add(radio_facile);
            groupBoxDifficulte.Controls.Add(radio_difficile);
        }

        private void btnPerception_Click(object sender, EventArgs e)
        {
           
            View.FormPerception f = new View.FormPerception();
            View.FormPerception.cptTest = 1;// cpt test étant static, si on revient au menu puis relance le test de perception, cptTest garde sa valeur précédente;Il faut donc le réinitialiser
            f.Show();
            
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            View.FormCalculMental f = new View.FormCalculMental();
            f.Show();
        }

        

        private void btn_maths_Click(object sender, EventArgs e)
        {
            string matiere = ((Button)(sender)).Text;
            View.FormProbleme f = new View.FormProbleme(matiere);
            f.Show();

        }


        private void btnConcentration_Click(object sender, EventArgs e)
        {
            View.FormConcentration f = new View.FormConcentration();
            f.Show();
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

        


    }
}
