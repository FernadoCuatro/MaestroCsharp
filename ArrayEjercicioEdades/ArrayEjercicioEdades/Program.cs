using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicioEdades
{
 class Program
 {
  static void Main(string[] args)
  {
   // Que el numero sea mayor que 18 y menor que 35 y que este dentro del array
   int[] numeros = { 31, 34, 37, 46, 20, 42 };

   Console.WriteLine("\nLos numeros mayores a 18 y menos que 35:");
   foreach (int numero in numeros) {
    if (numero > 18 && numero < 35) {
     Console.Write("| " + numero + " | ");
    }
   }

   //Que el numero sea igual o mayor a 0
   int[] numeros2 = { -100, 43, -232, 1, 12, -23 };

   int c = 0;

   Console.WriteLine("\n\nLos numeros positivos son:");
   foreach (int numero2 in numeros2) {
    if(numero2 >= 0) {
     //Console.Write("| " + numero2 + " | ");
     c++; // Aumentamos en 1 y contamos cuantos numeros poitivos hay
    }
   }
   Console.WriteLine("El numero de enteros positivos es: " + c);

   Console.ReadKey();
  }
 }
}
