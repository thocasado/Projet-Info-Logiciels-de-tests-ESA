using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GenieLog.Presenter
{
    class Presenter
    {
        private View.MyView view { get; set; }
        private Tests tests { get; set; }
        public Niveau difficile = Niveau.Difficile;
        public Niveau facile = Niveau.Facile;

        public Presenter()
        {

        }
        public Presenter (View.MyView v)
        {
            view = v;
            
        }


    }
}
