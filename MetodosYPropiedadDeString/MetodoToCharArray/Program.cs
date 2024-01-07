using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
           // Convierte una cadena y obtiene cada uno de sus caracteres y lo almace en un array
            
            string nombre = "Pepe come rico";
            char[] array= nombre.ToCharArray();
            int c = 0;

            foreach(char item in array)
            {
                if (item.Equals('e')) c++;
            }

            Console.WriteLine("Se repite la letra e " + c + " veces");
            Console.ReadLine();
        }
    }
}
