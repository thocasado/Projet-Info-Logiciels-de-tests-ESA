using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_GenieLog
{
    public partial class MyMessageBox : Form
    {
        string[] bonneReponse=new string [3];//on définit de base avec 3réponses; s'il y en a 4 il sera redéfini
        string[] repUtilisateur=new string[3];
        int cptBR;//compte le nbre de bonnes réponses
        

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public void setAnswerVisibility()
        {
            if (Perception.nbFormeVoulue == 3)
            {
                lettre4LB.Visible = false;
                textBox4.Visible = false;
                
            }
            else//voir si on ne le met pas et qu'on met de base visible=true si ca marche 
            {
                lettre4LB.Visible = true;
                textBox4.Visible = true;
                bonneReponse = new string[4];
                repUtilisateur = new string[4];
            }
        }

        public void setLabelText()
        {
            //int cpt=0;
           // var test = Perception.tableauFormeVoulue;
           /* foreach (Control c in Controls)
            {
                if (c is Label && cpt<Perception.nbFormeVoulue)// si trop le bordel pour savoir qui est qui -> implémentation de label 1 à 1 
                {
                    c.Text = Perception.tableauFormeVoulue[cpt].Letter;
                    bonneReponse[cpt] = Perception.tableauFormeVoulue[cpt].Value.ToString();//on récupère la réponse attendue ici
                    cpt++;
                }
            }

            */
            count.Text = View.FormPerception.compteur.ToString() + "/10";
            lettre1LB.Text = Perception.tableauFormeVoulue[0].Letter;
            lettre2LB.Text = Perception.tableauFormeVoulue[1].Letter;
            lettre3LB.Text = Perception.tableauFormeVoulue[2].Letter;
            if (Perception.nbFormeVoulue == 4)
            {
                lettre4LB.Text = Perception.tableauFormeVoulue[3].Letter; 
            }

            for (int i = 0; i < bonneReponse.Length; i++)
            {
                bonneReponse[i] = Perception.tableauFormeVoulue[i].Value.ToString();
            }

            

            


        }

        private void validButton_Click(object sender, EventArgs e)
        {
            cptBR = 0;
            repUtilisateur[0]=textBox1.Text;
            repUtilisateur[1]=textBox2.Text;
            repUtilisateur[2]=textBox3.Text;
            if (Perception.nbFormeVoulue==4)
            {
                repUtilisateur[3]=textBox4.Text;
            }
            for (int cpt=0;cpt<bonneReponse.Length;cpt++)
            {
                    if (repUtilisateur[cpt] == bonneReponse[cpt])
                    {
                        cptBR++;
                    }
            }
                
                
                
                
            
            MessageBox.Show(cptBR.ToString() + "/" + Perception.nbFormeVoulue);
            this.SetVisibleCore(false);
            View.FormPerception fp = new View.FormPerception();
            fp.ShowDialog();
            
           // fp.Show();
            
        }




       
    }
}
