using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            try
            {
                string numero = "45";
                int.Parse(numero);
           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hola como estas soy un finally");
            }

                 Console.WriteLine("Hola");
            /*
            string numero = "123a";
            try
            {
                int numeroConvertido = int.Parse(numero);
                Console.WriteLine("Numero convertido " + numeroConvertido);
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir a entero");
            }
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            */
            /*int numero1 = 9, numero2 = 0;*/


            /*
            try
            {
                int resultado = numero1 / numero2;
                int resultado1 = numero1 / numero2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocurrio un error , no se puede dividir entre cero");
            }
           
            Console.WriteLine("Hola");
            */


            Console.ReadLine();

        }
    }
}
