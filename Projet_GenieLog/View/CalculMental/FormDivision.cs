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

    public partial class FormDivision : Form
    {
        //gerer cas difficile avec timer, repeter 10 fois l'opération, afficher le pourcentage de succès a la fin et sur le coté à chaque tour. Sauvegarder le taux de résultat
        string result;
        int cpt = 0;
        public FormDivision()
        {
        InitializeComponent();
            Random r = new Random();
            int b = r.Next(1, 10);
            int a = r.Next(10, 100);
            int aux;//stockage temporaire du resultat
            double reste = a % b;
            if(reste>(b/2))
            {
                aux=(a/b)+1;
            }
            else
            {
                aux=a/b;
            }
            result=aux.ToString();
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
