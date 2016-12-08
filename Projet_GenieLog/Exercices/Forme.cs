using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_GenieLog
{
    public class Forme
    {
        public string Color { get; set; }
            public string Shape { get; set; }
            public int Value { get; set; }
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public string Letter { get; set; }

            public Forme()
            {

            }
            public Forme(string color, string shape, int value, int posX, int posY, string letter)
            {
                Color = color;
                Shape = shape;
                Value = value;
                PositionX = posX;
                PositionY = posY;
                Letter = letter;
            }

            public override string ToString()
            {
                string ch = "forme:" + Shape + " color:" + Color + " value:" + Value + " letter: " + Letter;
                return ch;
            }
        }



    
}
