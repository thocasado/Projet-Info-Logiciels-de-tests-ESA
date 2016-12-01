﻿using System;
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
            string randomRule = Perception.generateRule();
            MessageBox.Show(randomRule);    
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Perception.generateShapes();
            Perception.drawNumbers(e);

        }

        private void FormPerception_Load(object sender, EventArgs e)
        {

            
        }

        
    }
}
