using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSplit
{
    class Program
    {
        static void Main(string[] args)
        { // Nos permiti devidir separar por el caracter ingresado un array de string 

            string mensaje = "Hola amigos como estan";

           string[] array=  mensaje.Split(' ');
                 foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Numero de palabras " + array.Length);
            Console.ReadLine();
        }
    }
}
