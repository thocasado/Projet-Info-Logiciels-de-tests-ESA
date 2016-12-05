using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GenieLog.View
{
    public partial class MyMessageBox : Form
    {
        private int nbrAnswer = Perception.rndNumberShapes;
        public void setAnswerVisibility()
        {
            if (nbrAnswer == 4)
            {
                label4MMB.Visible = true;
                textBox4MMB.Visible = true;

            }
            else
            {
                label4MMB.Visible = false;
                textBox4MMB.Visible = false;
            }
        }
        public MyMessageBox()
        {
            InitializeComponent();
            
        }

    }
}
