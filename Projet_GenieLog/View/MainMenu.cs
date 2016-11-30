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
        bool difficile = false;
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void btnPerception_Click(object sender, EventArgs e)
        {
            View.FormPerception f = new View.FormPerception();
            f.Show();
            
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            View.FormCalculMental f = new View.FormCalculMental();
            f.Show();
        }

        private void radio_difficile_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_difficile.Checked == true)
            {
                difficile = true;
            }
        }

    }
}
