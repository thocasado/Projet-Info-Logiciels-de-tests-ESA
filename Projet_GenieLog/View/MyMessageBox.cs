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
        public int badAnswers;
        public void setAnswerVisibility()
        {
            if (Perception.rndNumberShapes == 4)
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
            int cpt = 0;
            var test = Perception.listFormes;
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        c.Text = Perception.listFormes[cpt].Letter;
                    cpt++;             
                        //bool keepGoing = true;
                        //for (int i =cpti; i<3 && keepGoing ;i++)
                        //{ 
                        //    for (int j=cptj; j<4 && keepGoing ;j++)
                        //    {
                        //        switch (Perception.ruleNumber)
                        //        {
                        //            case "1":
                        //                if (Perception.arrayFormes[cpti,cptj].Color == "Yellow" && Perception.arrayFormes[cpti, cptj].Shape == "Rectangle")
                        //                {
                        //                    c.Text = Perception.arrayFormes[cpti, cptj].Letter.ToString();
                        //                    keepGoing = false;
                        //                }

                        //                break;

                        //            case "2":
                        //                if (Perception.arrayFormes[cpti, cptj].Color == "Blue" && Perception.arrayFormes[cpti, cptj].Shape == "Rectangle")
                        //                {
                        //                    c.Text = Perception.arrayFormes[cpti, cptj].Letter.ToString();
                        //                    keepGoing = false;
                        //                }

                        //                break;

                        //            case "3":
                        //                if (Perception.arrayFormes[cpti, cptj].Color == "Yellow" && Perception.arrayFormes[cpti, cptj].Shape == "Ellipse")
                        //                {
                        //                    c.Text = Perception.arrayFormes[cpti, cptj].Letter.ToString();
                        //                    keepGoing = false;
                        //                }

                        //                break;

                        //            case "4":
                        //                if (Perception.arrayFormes[cpti, cptj].Color == "Yellow" && Perception.arrayFormes[cpti, cptj].Shape == "Ellipse")
                        //                {
                        //                    c.Text = Perception.arrayFormes[cpti, cptj].Letter.ToString();
                        //                    keepGoing = false;
                        //                }

                        //                break;
                        //            default: break;

                        //        }
                        //        cptj++;

                        //    }

                        //    cpti++;
                        //}
                        //foreach (Perception.Forme f in Perception.arrayFormes)
                        //{
                        //    switch (Perception.ruleNumber)
                        //    {
                        //        case "1":
                        //            if (f.Color == "Yellow" && f.Shape == "Rectangle")
                        //            {
                        //                c.Text = f.Letter.ToString();
                        //            }
                        //            break;

                        //        case "2":
                        //            if (f.Color == "Blue" && f.Shape == "Rectangle")
                        //            {
                        //                c.Text = f.Letter.ToString();
                        //            }
                        //            break;

                        //        case "3":
                        //            if (f.Color == "Yellow" && f.Shape == "Ellipse")
                        //            {
                        //                c.Text = f.Letter.ToString();
                        //            }
                        //            break;

                        //        case "4":
                        //            if (f.Color == "Yellow" && f.Shape == "Ellipse")
                        //            {
                        //                c.Text = f.Letter.ToString();
                        //            }
                        //            break;

                        //    }

                        //}

                    
                }
            }
            
        }


        public void getResults()
        {
            //foreach(TextBox t in this.Controls)
            //{
            //    if (t.Visible == true && t.Text == )
            //}
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
