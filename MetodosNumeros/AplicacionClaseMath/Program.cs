using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio = 20.7;
            int a = 2;
            int b = 5;
            int c = 37;
            int d = -2;
         Console.WriteLine("Math.Floor(20.6) :"+  Math.Floor(precio));
            Console.WriteLine("Math.ceiling " + Math.Ceiling(precio));
            Console.WriteLine("Math.round :" + Math.Round(precio));
            Console.WriteLine("Potencia :" + Math.Pow(a, b));

            Console.WriteLine("Raiz " + Math.Sqrt(c));

            Console.WriteLine("El mayor es " + Math.Max(b, c));

            Console.WriteLine("El menor es " + Math.Min(a, b));

            Console.WriteLine("El valor absoluto es :" + Math.Abs(d));

            Console.ReadLine();


        }
    }
}
