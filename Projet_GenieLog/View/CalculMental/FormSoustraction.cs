using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_GenieLog.View.CalculMental
{
    public partial class FormSoustraction : Form
    {
        //gerer cas difficile avec timer, repeter 10 fois l'opération, afficher le pourcentage de succès a la fin et sur le coté à chaque tour. Sauvegarder le taux de résultat
        string result;
        int cpt = 0;//compteur de bonne réponse; 
        public FormSoustraction()
        {
            InitializeComponent();
            Random r = new Random();
            int b = r.Next(10, 1000);
            int a = r.Next(b+1, 1000);
            result = (a - b).ToString();
            chiffre1.Text = a.ToString();
            chiffre2.Text = b.ToString();
        }

        private void validButton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(saisieResultat.Text);
            if (saisieResultat.Text == result)
            {
                MessageBox.Show("Juste!");
                cpt++;
            }
            else
            {
                MessageBox.Show("Faux.." + result);
            }
            

        }
    }
}
