using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "ABC 234";

          string nuevoMensaje=  mensaje.Replace(" ", "-");
            Console.WriteLine("El nuevo mensaje es : " + nuevoMensaje);
            Console.ReadLine();
        }
    }
}
