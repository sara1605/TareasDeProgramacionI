using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que produzca los numeros aacb, bca, bcbc.
             Donde a=2, b=4 y c=1
            */

            //Para aacb
            double n = (117 * 10 + 7);
            double o = (518.5 + 518.5);
            double resultado = 0.0;

            resultado = n + o;
            Console.WriteLine ("El resultado de la operación {0}+{1} es {2}", n, o, resultado);

            //Para bca
            double p = 103;
            double q = ((3 * 34)+1);
            double r = (1564 / 4);
            double s = 185;

            resultado = (p + q + r) - s;
            Console.WriteLine("El resultado de la operacion ({0}+{1}+{2})-{3} es {4}", p,q,r,s,resultado);

            //Para bcbc
            double t = (8452 - 6520);
            double u = (1104.5 * 2);

            resultado = (t + u);
            Console.WriteLine("El resultado de la operacion {0}+{1} es {2}", t, u, resultado);
            
            Console.ReadLine();

        }
        
    }
}
