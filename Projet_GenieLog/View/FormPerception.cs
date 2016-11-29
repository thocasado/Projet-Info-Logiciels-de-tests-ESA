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
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        public FormPerception()
        {
            InitializeComponent();
        }

        private void createCircle(int x, int y, int width, int height) // permet de creer un cercle 
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(blueBrush, new Rectangle(x, y, width, height));
            blueBrush.Dispose();
            formGraphics.Dispose();
        }

        private void createSquare(int x, int y, int width, int height) // permet de creer un carré
        {
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(yellowBrush, new Rectangle(x, y, width, height));
            yellowBrush.Dispose();
            formGraphics.Dispose();
        }

        private void randomizeShapes()
        {
            Random rnd = new Random();
            int nbr;
            int color;

            for (int i=1; i<=3;i++)
            {
                for (int j=1;j<=4;j++)
                {
                    nbr = rnd.Next(1, 3);
                    if(nbr ==1)
                    {
                        color = rnd.Next(0, 2);
                        if(color==0)
                        { createSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                        else
                        {
                            createSquare(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                        }
                        
                    }
                    else
                    {
                        color = rnd.Next(0, 2);
                        if (color == 0)
                        { createCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50); }
                        else
                        {
                            createCircle(25 + 105 * (j - 1), 30 + 95 * (i - 1), 50, 50);
                        }
                        
                    }
                    
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            randomizeShapes();
            
        }

    }
}
