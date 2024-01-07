using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
 class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine("Suma: " + calculadora(3,4,'+') );
   Console.WriteLine("Division: " + calculadora(10, 5, '/') );

   Console.ReadKey();
  }
  // trabajamos la funcion aqui
  static double calculadora(int a, int b, char operacion){
   double resultado = 0;

   switch (operacion)
   {
    case '+': resultado = a + b; break;
    case '-': resultado = a - b; break;
    case '*': resultado = a * b; break;
    case '/': resultado = a / b; break;

    default: resultado = 0; break;
   }

   return resultado;
  }
 }
}
