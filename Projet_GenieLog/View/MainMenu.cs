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
        //voir comment récupérer la difficulté dans les autres form 
        public bool difficile { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            groupBoxDifficulte.Controls.Add(radio_facile);
            groupBoxDifficulte.Controls.Add(radio_difficile);

            
        }

        private void btnPerception_Click(object sender, EventArgs e)
        {
            difficile=checkDifficulte();
            View.FormPerception f = new View.FormPerception();//rajouter difficulte en paramètre
            f.Show();
            
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            difficile=checkDifficulte();
            View.FormCalculMental f = new View.FormCalculMental(difficile);
            f.Show();
        }

        

        private void btn_maths_Click(object sender, EventArgs e)
        {
            difficile=checkDifficulte();
            string matiere = ((Button)(sender)).Text;
            View.FormProbleme f = new View.FormProbleme(matiere,difficile);
            f.Show();

        }

        private bool checkDifficulte()
        {
            if (radio_difficile.Checked == true)
            {
                difficile = true;
            }
            else
            {
                difficile = false;
            }
            return difficile;
        }

        private void btnConcentration_Click(object sender, EventArgs e)
        {
            difficile = checkDifficulte();
            View.FormConcentration f = new View.FormConcentration(difficile);//rajouter difficulte en paramètre
            f.Show();
        }


    }
}
