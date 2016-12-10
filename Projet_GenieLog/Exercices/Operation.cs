using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_GenieLog
{
    public class Operation 
    {



        public static int[] realisationCalcul(string type)
        {
            int[] valeurs = new int[3];
            int result = 0;
            Random r = new Random();
            int a = 0;
            int b = 0;

            switch (type)
            {
                case "+":
                    a = r.Next(100, 1000);
                    b = r.Next(100, 1000);
                    result = (a + b);
                    break;
                case "-":
                    b = r.Next(10, 1000);
                    a = r.Next(b + 1, 1000);
                    result = (a - b);
                    break;
                case "x":
                    a = r.Next(10, 100);
                    b = r.Next(1, 10);
                    result = (a * b);
                    break;
                case "/":
                    a = r.Next(10, 100);
                    b = r.Next(1, 10);

                    int aux;//stockage temporaire du resultat
                    double reste = a % b;
                    if (reste > (b / 2))
                    {
                        aux = (a / b) + 1;
                    }
                    else
                    {
                        aux = a / b;
                    }
                    result = aux;
                    break;
            }
            valeurs[0] = a;
            valeurs[1] = b;
            valeurs[2] = result;

            return valeurs;


        }
    }
}