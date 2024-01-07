using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumaPares
{
 class Program
 {
  static void Main(string[] args)
  {
   int[] numeros = { 1, 3, 2, 4, 11, 19 };
   int suma = 0;

   foreach(int numero in numeros)
   {
    if (numero % 2 == 0)
     suma += numero;
   }

   Console.WriteLine("La suma de los numeros pares es: " + suma);

   Console.ReadKey();

  }
 }
}
