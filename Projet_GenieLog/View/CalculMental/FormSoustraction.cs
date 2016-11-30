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
        //gerer cas difficile avec timer, mettre timer pour fermer messageBox et passer au calcul suivant(geré au clic pour le moment) 
        //Sauvegarder le taux de résultat; valider avec entrée
        //Ameliorer affichage
        string result;
        int cpt = 0;//compteur de bonne réponse;
        int compteur = 0;
        public FormSoustraction()
        {
            InitializeComponent();
            lancerTest();
            
        }

        private void lancerTest()
        {
            compteur++;
            count.Text = compteur.ToString() + "/10";
            saisieResultat.Clear();
            Random r = new Random();
            int b = r.Next(10, 1000);
            int a = r.Next(b + 1, 1000);
            result = (a - b).ToString();
            chiffre1.Text = a.ToString();
            chiffre2.Text = b.ToString();
        }

        private void validButton_Click(object sender, EventArgs e)
        {

            if (saisieResultat.Text == result)
            {
                MessageBox.Show("Juste!");
                cpt++;
            }
            else
            {
                MessageBox.Show("Faux\n" + result);
            }
            if (compteur != 10)
            {
                lancerTest();
            }
            else
            {
                MessageBox.Show("Vous avez eu un total de"+cpt + "/10 !");
                this.Close();
            
            }
            

        }

        
    }
}
