using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nos permite obtener parte de una cadena 
            string pasaporte = "12345678";
            string nombre = "Pepe lucho";

            //Codigo las tres primeras letras y sus tres iniciales de su nombre

           string pasT =  pasaporte.Substring(0, 3);
           string nombreT = nombre.Substring(0, 3);

            Console.WriteLine("Su codigo es " + pasT + nombreT.ToUpper());
    
            Console.ReadLine();

        }
    }
}
