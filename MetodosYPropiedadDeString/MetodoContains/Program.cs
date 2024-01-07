using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoContains
{
    class Program
    {
        static void Main(string[] args)
        {   // Nos indica si un valor esta contenido dentro de la cadena 
            string mensaje = " Me fui a comprar al cine";

            if (mensaje.Contains("fue"))
            {x
                Console.WriteLine("Se encuentra");
            }else
            {
                Console.WriteLine("No esta");

            }

            Console.ReadLine();

        }
    }
}
