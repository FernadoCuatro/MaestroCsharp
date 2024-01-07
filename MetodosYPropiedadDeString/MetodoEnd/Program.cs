using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEnd
{
    class Program
    {
        static void Main(string[] args)
        {    // Indica si termina con una cadena ingresada como parametro
            string apellido = "Romam";

            if (apellido.EndsWith("m"))
            {
                Console.WriteLine("Termina con m");
            }
            else
            {
                string ultimaLetra = apellido.Substring(apellido.Length - 1, 1);
                Console.WriteLine("No Termina con m , termina con "+ultimaLetra);

            }
            Console.ReadLine();


        }
    }
}
