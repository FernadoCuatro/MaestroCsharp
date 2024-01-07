using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEjerciciosDos
{
 class Program
 {
  static void Main(string[] args)
  {
   // Contadores y acumuladores

   // Ingresar un numero y calcular si triple hasta
   // que se ingrese el numero 0
   int valor = 1;
   while (valor != 0)
   {
    Console.WriteLine("\nIngrese un numero");
    valor = int.Parse(Console.ReadLine());

    Console.WriteLine("El triple del numero ingresado es: " + valor*3);
   }


   Console.WriteLine("\n************\nFinalizo el programa\n************");
   Console.ReadLine();
  }
 }
}
