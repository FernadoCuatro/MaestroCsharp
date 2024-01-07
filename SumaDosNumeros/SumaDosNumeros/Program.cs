using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDosNumeros
{
 class Program
 {
  static void Main(string[] args)
  {
  	
   Console.WriteLine("Ingrese el primer numero: ");
   string numero1 = Console.ReadLine();
   int num1 = int.Parse(numero1);
   // int numeroSum1 = int.Parse(Console.ReadLine());
   Console.WriteLine("Ingrese el segundo numero: ");
   string numero2 = Console.ReadLine();
   int num2 = int.Parse(numero2);

   // int numeroSum2 = int.Parse(Console.ReadLine());
   Console.WriteLine("\nLa suma de los numeros es: " + (num1 + num2));
   Console.ReadLine();
  }
 }
}
