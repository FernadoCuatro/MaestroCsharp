using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosToUpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string utiles = "Me fui de Paseo";

            Console.WriteLine(utiles.ToUpper()); // Convierte la cadena a mayusculas
            Console.WriteLine(utiles.ToLower()); // Convierte la cadena a minuscula

            string nombre1 = "Pablo"; //PABLO
            string nombre2 = "pablo"; //PABLO

            if (nombre1.ToLower().Equals(nombre2.ToLower()))
            {
                Console.WriteLine("Son igualitos");
            }
            else{
                Console.WriteLine("Son diferentes");
            }

                Console.ReadLine();
        }
    }
}
