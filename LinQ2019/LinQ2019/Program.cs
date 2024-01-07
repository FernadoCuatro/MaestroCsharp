using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2019
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   int[] numeros = { 99, 56, 76, 45, 23 };

   // Definir la consulta
   var consulta = from numero in numeros
                  where numero > 70
                  select numero;

   // ejecutamos la consulta
   foreach (int item in consulta)
   {
    Console.WriteLine(item);
   }

   Console.ReadKey();
  }
 }
}
