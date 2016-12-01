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
        string type;
        bool _difficile;
        
        public FormCalculMental(bool difficile)
        {
            InitializeComponent();
            _difficile = difficile;

        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            type = ((Button)(sender)).Text;
            View.CalculMental.FormOperation f = new View.CalculMental.FormOperation(type,_difficile);
            f.Show();
            this.Close();
        }

        /*private void sousButton_Click(object sender, EventArgs e)
        {
            type = "-";
            View.CalculMental.FormSoustraction f = new View.CalculMental.FormSoustraction();
            f.Show();
            this.Close();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            type = "x";
            View.CalculMental.FormMultiplication f = new View.CalculMental.FormMultiplication();
            f.Show();
            this.Close();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            type = "/";
            View.CalculMental.FormDivision f = new View.CalculMental.FormDivision();
            f.Show();
            this.Close();
        }*/




        

       
       
    }
}
