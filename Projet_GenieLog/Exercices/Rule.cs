using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GenieLog
{
    public class Rule
    {
        public string Text { get; set; }
        public int Number { get; set; }

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
