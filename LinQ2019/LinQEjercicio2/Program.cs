using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQEjercicio2
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   int[] numeros = { 21, 56, 18, 24, 12 };

   // definimos la consulta
   var consulta = from edad in numeros
                  where edad < 90
                  select edad;

   // Recorremos los datos
   foreach (int edad in consulta)
   {
    Console.WriteLine(edad);
   }

   Console.ReadKey();
  }
 }
}
