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

        public FormPerception()
        {
            InitializeComponent();
        }

        private void createCircle()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, 20, 20, 10, 10);
        }

        private void createSquare(int x, int y, int width, int height)
        {
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(x, y, width, height));
            myBrush.Dispose();
            formGraphics.Dispose();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            createSquare(30, 30, 50, 50)
;
            
           
        }

    }
}
