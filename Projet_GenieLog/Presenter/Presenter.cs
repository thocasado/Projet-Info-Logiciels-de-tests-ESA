using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GenieLog
{
    public class Presenter
    {
        private MyView view { get; set; }
        private Exercices tests { get; set; }
        public Niveau difficile = Niveau.Difficile;
        public Niveau facile = Niveau.Facile;


        public Presenter (MyView v)
        {
            view = v;
            
        }
        public void loadTest(object sender, EventArgs eventargs)
        {
            switch (((Button)sender).Name)
            {
                case "btnPerception": View.FormPerception formP = new View.FormPerception();
                        formP.Show();
                    break;
                case "btnConcentration":
                case "btnCalcul":
                case "btnMathematiques":
                case "btnPhysique": break;

            }
        }


    }
}
