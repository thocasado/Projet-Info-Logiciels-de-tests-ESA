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
        int cptBonneReponse;
        static int cptBonneReponseTotal = 0;
        static int cptNombreFormeTotal = 0;
        int cptTest = View.FormPerception.cptTest;
        

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public void reponseVisible()
        {
            if (Perception.nbFormeVoulue == 3)
            {
                lettre4LB.Visible = false;
                textBox4.Visible = false;
                
            }
            else 
            {
                lettre4LB.Visible = true;
                textBox4.Visible = true;
                bonneReponse = new string[4];
                repUtilisateur = new string[4];
            }
        }

        public void implementationLabel()
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
            count.Text = cptTest.ToString() + "/10";
            lettre1LB.Text = Perception.tableauFormeVoulue[0].lettre;
            lettre2LB.Text = Perception.tableauFormeVoulue[1].lettre;
            lettre3LB.Text = Perception.tableauFormeVoulue[2].lettre;
            if (Perception.nbFormeVoulue == 4)
            {
                lettre4LB.Text = Perception.tableauFormeVoulue[3].lettre; 
            }

            for (int i = 0; i < bonneReponse.Length; i++)
            {
                bonneReponse[i] = Perception.tableauFormeVoulue[i].valeur.ToString();
            }

            

            


        }

        private void validButton_Click(object sender, EventArgs e)
        {
            cptBonneReponse = 0;
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
                        cptBonneReponse++;
                    }
            }
                
                
                
                
            
            MessageBox.Show(cptBonneReponse.ToString() + "/" + Perception.nbFormeVoulue);
            cptNombreFormeTotal += Perception.nbFormeVoulue;
            cptBonneReponseTotal += cptBonneReponse;
            this.SetVisibleCore(false);
            
            if (cptTest != 10)
            {
                View.FormPerception fp = new View.FormPerception();
                fp.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Vous avez eu un score total de " + cptBonneReponseTotal + "/" + cptNombreFormeTotal);
                View.FormPerception.cptTest = 1;
            }
            
           
            
        }




       
    }
}
