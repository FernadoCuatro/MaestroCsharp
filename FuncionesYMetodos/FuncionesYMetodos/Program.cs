using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesYMetodos
{
 class Program
 {
  static void Main(string[] args)
  {
   // Lo tradicional
   int a = 20, b = 10, suma = a + b;

   //Para eso hacemos una funcion, pero la funcion la hacemos fuera del metodo Main
   Console.WriteLine("La suma de los numeros es: " + sumatoria(4,4));

   Console.ReadKey();
  }
  // Trabajamos la funcion aca
  static int sumatoria(int a, int b){
   return a + b;
  }

 }
}
