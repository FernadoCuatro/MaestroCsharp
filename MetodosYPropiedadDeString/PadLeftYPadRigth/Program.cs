using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadLeftYPadRigth
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo1 = "ABC";
            string codigo2 = "ABCDE";

            Console.WriteLine("COdigo 1 : " + codigo1.PadLeft(8, '0'));
            Console.WriteLine("Codigo 2: " + codigo2.PadLeft(8, '0'));

            Console.WriteLine("COdigo 1 : " + codigo1.PadRight(8, '0'));
            Console.WriteLine("Codigo 2: " + codigo2.PadRight(8, '0'));

            Console.ReadLine();

        }
    }
}
