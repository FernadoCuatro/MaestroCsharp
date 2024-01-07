using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMetodos
{
    class Program
    {
        static void Main(string[] args)
        { // Nos devuelve true si una cadena comienza o inica con la cadena ingresada 

            string[] nombres = { "Pepe", "Pedro", "Damian" ,
            "Fernando" , "Dino"};
            int c = 0;
            foreach(string nom in nombres)
            {
                if (nom.StartsWith("D")) c++;
                 
            }
            Console.WriteLine("Numero de veces " + c);

            Console.ReadLine();
        }
    }
}
