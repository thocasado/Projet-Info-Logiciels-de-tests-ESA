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
    public partial class FormPerception : Form
    {
        MyMessageBox mb = new MyMessageBox();

        static Perception regle;
        static Forme[,] tableauForme; 
        int tempsDifficulte = 4000;//on l'initialise au temps Niveau facile
        public static int compteur = 0;//compteur pour savoir à quel test on est
        
        public FormPerception()
        {
            InitializeComponent();
            if(MainMenu.difficile)
            {
                tempsDifficulte = 2000;
            }
            lancerTest();

        }

       
        public  void lancerTest()
        {
             
            regle = Perception.selectionRegle();
            compteur++;
            
             MessageBox.Show(regle._consigne);
             Perception.generateRandomArray();
             tableauForme=Perception.generateShapes(regle);
             count.Text = compteur.ToString() + "/10";

             
            
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            count.Text = compteur.ToString() + "/10";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Perception.createColoredShape(tableauForme[i, j], this);
                    
                }
            }
            Perception.drawNumbers(e);
            timerReponse.Interval = tempsDifficulte;
            timerReponse.Start();
        }

        private void timerReponse_Tick(object sender, EventArgs e)
        {
            timerReponse.Stop();
            this.SetVisibleCore(false);
            mb.setAnswerVisibility();
            mb.setLabelText();
            mb.ShowDialog();
            mb.Close();

           
           
            
        }
            

       

        
    }
}
