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
        int tempsDifficulte = 500;//on l'initialise au temps du Niveau facile
        public static int cptTest = 1;
        
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
            
            
             MessageBox.Show(regle._consigne);
             Perception.generationTableauValeur();
             tableauForme=Perception.generateShapes(regle);
             count.Text = cptTest.ToString() + "/10";
             cptTest++;

             
            
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Perception.createColoredShape(tableauForme[i, j], this);
                    
                }
            }
            Perception.dessineNombres(e);
            timerReponse.Interval = tempsDifficulte;
            timerReponse.Start();
        }

        private void timerReponse_Tick(object sender, EventArgs e)
        {
            timerReponse.Stop();
            this.SetVisibleCore(false);
            mb.reponseVisible();
            mb.implementationLabel();
            mb.ShowDialog();

           
           
            
        }
            

       

        
    }
}
