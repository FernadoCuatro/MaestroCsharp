using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRango
{
 class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine("Ingrese el rango 1: ");
   int rango1 = int.Parse(Console.ReadLine());
   Console.WriteLine("Ingrese el rango 2: ");
   int rango2 = int.Parse(Console.ReadLine());

   for (int i = rango1; i <= rango2; i++){
    if (i % 2 == 0)
    {
     Console.WriteLine(i);
    }
   }
   Console.ReadLine();
  }
 }
}
