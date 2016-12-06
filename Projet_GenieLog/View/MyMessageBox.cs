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
        private Perception.Forme[,] arrayF = Perception.arrayFormes;
        public int badAnswers;
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

        public void setLabelText()
        {
            foreach(Label l in Controls)
            {
                foreach(Perception.Forme f in Perception.arrayFormes)
                {
                    switch (Perception.ruleNumber)
                    {
                        case "1":
                            if (f.Color == "Yellow" && f.Shape == "Rectangle")
                    }
                }
            }
        }

        public void getResults()
        {
            foreach(Label l in this.Controls)
            {

            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
