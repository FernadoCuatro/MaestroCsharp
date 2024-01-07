using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rangoNumeroMetodo
{
 class Program
 {
  static void Main(string[] args)
  {
   rangoIm(4, 15);

   Console.ReadKey();
  }

  static void rangoIm(int inicio, int fin)
  {
   for (int i = inicio; i <= fin; i++)
   {
    Console.WriteLine(i);
   }
  }
 }
}
