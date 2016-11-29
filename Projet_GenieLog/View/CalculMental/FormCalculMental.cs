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

        

       
       
    }
}
