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
    public partial class FormCalculMental : Form
    {
        public FormCalculMental()
        {
            InitializeComponent();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormAddition f = new View.CalculMental.FormAddition();
            f.Show();
        }

        private void sousButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormSoustraction f = new View.CalculMental.FormSoustraction();
            f.Show();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormMultiplication f = new View.CalculMental.FormMultiplication();
            f.Show();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormDivision f = new View.CalculMental.FormDivision();
            f.Show();
        }




        

       
       
    }
}
