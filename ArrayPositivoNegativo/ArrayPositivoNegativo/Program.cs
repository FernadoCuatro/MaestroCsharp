using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPositivoNegativo
{
 class Program
 {
  static void Main(string[] args)
  {
   // Calcular cuandot s numeros postivios y negativos hay en el Array
   int[] numeros = { 4, 5, -4, 7, 8, -2, 12, 176, -6 };
   int conPositivos = 0, conNegativos = 0, sumPositivos = 0, sumNegativos = 0;

   foreach (int num in numeros)
   {
    if (num > 0) { 
     conPositivos += 1;
     sumPositivos += num;
    }
    else { 
     conNegativos += 1;
     sumNegativos += num;
    }
   }

   Console.WriteLine("Positivos |" + conPositivos + "|  Negativos |" + conNegativos + "|");
   Console.WriteLine("SUMA DE LOS NUMEROS");
   Console.WriteLine("Positivos |" + sumPositivos + "|  Negativos |" + sumNegativos + "|");
   Console.ReadKey();

  }
 }
}
