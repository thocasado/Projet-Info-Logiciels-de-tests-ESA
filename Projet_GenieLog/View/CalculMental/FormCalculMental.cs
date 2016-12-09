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
        
        public FormCalculMental()
        {
            InitializeComponent();
            _difficile = MainMenu.difficile;

        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            type = ((Button)(sender)).Text;
            View.CalculMental.FormOperation f = new View.CalculMental.FormOperation(type,_difficile);
            f.Show();
            this.Close();
        }

       




        

       
       
    }
}
