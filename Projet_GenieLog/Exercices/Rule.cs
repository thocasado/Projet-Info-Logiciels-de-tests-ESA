using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GenieLog
{
    public class Rule
    {
        private string Text { get; set; }
        private int Number { get; set; }

        public Rule()
        {

        }

        public Rule(int number, string text)
        {
            Text = text;
            Number = number;
        }

        public Rule(string text)
        {
            Text = text;
        }


    }
}
