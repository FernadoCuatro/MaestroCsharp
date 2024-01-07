using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero = "15";
            int resultado;

            bool exito=   Int32.TryParse(numero, out resultado);
            int suma = resultado + 5;

            Console.WriteLine("La suma es :" + suma);


            Console.ReadLine();


        }
    }
}
