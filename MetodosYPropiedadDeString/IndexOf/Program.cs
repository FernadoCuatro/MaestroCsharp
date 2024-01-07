using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string pais = "Nicaragua";
            if (pais.IndexOf("p") > -1)
            {
                Console.WriteLine("Se encontro");
            }else
            {
                Console.WriteLine("No se encontro");

            }
            Console.ReadLine();
        }
    }
}
