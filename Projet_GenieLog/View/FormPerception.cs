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
        Perception p = new Perception();

        public FormPerception()
        {
            InitializeComponent();
            
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            p.drawShapes();
            p.generateRandomArray(e);          


        }

        private void FormPerception_Load(object sender, EventArgs e)
        {
            
            string randomRule = Perception.generateRule();
            MessageBox.Show(randomRule);
        }

        private void timerPerception_Tick(object sender, EventArgs e)
        {
            timerPerception.Stop();
            MyMessageBox mb = new MyMessageBox();
            mb.setAnswerVisibility();            
            mb.ShowDialog();           
            Invalidate(); // appeler cette méthode sinon bug d'affichage (appelle OnPaint) 

        }

        private void FormPerception_Shown(object sender, EventArgs e)
        {
            timerPerception.Start();
        }       
        
    }
}
