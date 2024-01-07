using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirTipoDato
{
 class Program
 {
  static void Main(string[] args)
  {
   String numero = "20";
   int numeroConver = int.Parse(numero);
   int resultado = numeroConver + 10;


   int a = 30; // Intero o decimal  se puede a pasar a cadena
   string cadena = a.ToString();

   Console.WriteLine(resultado);
   Console.ReadLine();
  }
 }
}
