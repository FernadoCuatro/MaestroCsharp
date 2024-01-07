using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eliminar espacios al princio y al final de una variable
            string apellido = " Gonzales Prada ";

            //10 (cuenta los espacios en blanco)

            Console.WriteLine(apellido.Length);
            // 8 (Por que no cuenta los espacios en blanco)
            Console.WriteLine(apellido.Trim().Length);

            string objeto = " Meza ";
            Console.WriteLine("Metodo TrimStart "+objeto.TrimStart().Length);
            Console.WriteLine("Metodo TrimEnd " + objeto.TrimEnd().Length);

            Console.ReadLine();
        }
    }
}
