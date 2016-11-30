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
        //Essayer de tout gérer à partir d'un seul et meme autre form puisque seul les conditions sur les variables, le signe et le résultat vont différer de l'interface (cf Jean) 
        public FormCalculMental()
        {
            InitializeComponent();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormAddition f = new View.CalculMental.FormAddition();
            f.Show();
            this.Close();
        }

        private void sousButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormSoustraction f = new View.CalculMental.FormSoustraction();
            f.Show();
            this.Close();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormMultiplication f = new View.CalculMental.FormMultiplication();
            f.Show();
            this.Close();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            View.CalculMental.FormDivision f = new View.CalculMental.FormDivision();
            f.Show();
            this.Close();
        }




        

       
       
    }
}
