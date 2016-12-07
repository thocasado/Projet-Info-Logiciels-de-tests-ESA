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
        Perception p = new Perception();

        public FormPerception()
        {

            InitializeComponent();
            string randomRule = Perception.generateRule();
            MessageBox.Show(randomRule);
            lancerTest();
            
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i=0; i<3;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Perception.createColoredShape(Perception.arrayFormes[i, j], this);
                }
            }
            p.drawNumbers(e); // on doit dessiner les chiffres après les formes sinon on ne les voit pas
            timerPerception.Start();
            //var test = Perception.listFormes;

                    
        }

        public void lancerTest()
        {
            p.generateRandomArray();// on doit générer le tableau de valeurs avant de dessiner les formes
            p.drawShapes();
        }

        //private void FormPerception_Load(object sender, EventArgs e)
        //{
            
        //    string randomRule = Perception.generateRule();
        //    MessageBox.Show(randomRule);

        //}

        private void timerPerception_Tick(object sender, EventArgs e)
        {
            timerPerception.Stop();
            
            mb.setAnswerVisibility();
            mb.setLabelText();
            mb.ShowDialog();

            Refresh(); // appeler cette méthode sinon bug d'affichage (appelle OnPaint) 

        }

        private void FormPerception_Shown(object sender, EventArgs e)
        {
            
        }       
        
    }
}
