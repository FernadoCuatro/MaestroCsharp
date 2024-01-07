using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEjercicios
{
 class Program
 {
  static void Main(string[] args)
  {
   // Acumulador y contadores, no son lo mismo.

   // Ingresar 10 numeros y encontrar su suma
   int i = 0, sumFin = 0;
   while (i < 10){
    Console.WriteLine(i+1 + "/10 Numeros");
    int num = int.Parse(Console.ReadLine());

    sumFin += num;
    i++;
   }
   Console.WriteLine("La suma total es de: " + sumFin);


   Console.ReadLine();
  }
 }
}
