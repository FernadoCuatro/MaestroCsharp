using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCadenas
{
 class Program
 {
  static void Main(string[] args)
  {
   //Operaiones con Cadenas
   string cad1 = "ABC";
   string cad2 = "DEF";
   int numero = 20;

   string resultado = cad1 + cad2;
   //Si se puede sumar el numero cadena. 

   // Nunca una cadena se puede multiplicar, tampoco se pueden dividir, solo se puede sumar.
   // Osea se concatena

   Console.WriteLine(resultado);
   Console.ReadLine();
  }
 }
}
