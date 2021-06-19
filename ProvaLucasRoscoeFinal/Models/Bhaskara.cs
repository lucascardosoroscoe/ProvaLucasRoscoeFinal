using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaLucasRoscoeFinal.Models
{
    public class Bhaskara
    {
        public void Main(string[] args)
        {
            bool convercao;
            double a, b, c;


            convercao = Double.TryParse(Console.ReadLine(), out a);


            convercao = Double.TryParse(Console.ReadLine(), out b);


            convercao = Double.TryParse(Console.ReadLine(), out c);

            calcularBhaskara(a, b, c);

        }

        public double calcularBhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x1 = (((b * (-1)) + Math.Sqrt(delta)) / (2 * a));
            double x2 = (((b * (-1)) - Math.Sqrt(delta)) / (2 * a));

            if (delta > 0)
            {
                if (x1 >= x2)
                {
                    return x1;
                }
                else
                {
                    return x2;
                }
            }
            else if (delta == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
    
