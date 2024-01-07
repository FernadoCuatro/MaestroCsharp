using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQOrderByInt
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   int[] numeros = { 9, 11, 4, 7, 12, 16, 15 };

   // Definicion de la consulta
   var consulta = from numero in numeros
                  orderby numero descending
                  select numero;

   // Ejercucion dde la consulta
   foreach (int item in consulta)
   {
    Console.WriteLine(item);
   }

   Console.ReadKey();
  }
 }
}
