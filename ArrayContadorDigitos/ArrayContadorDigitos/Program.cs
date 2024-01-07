using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContadorDigitos
{
 class Program
 {
  static void Main(string[] args)
  {
   // Indicar cuantos numeros de 1 cifra 3 cifras positivos hay

   int[] numeros = { 10, 4, 6, 11, 145, 3453, 22, 44, 1, -6, -8 };

   int contUnaCifra = 0, contDosCifra = 0;

   foreach (int numero in numeros)
   {
    // 1 cifra es de 0 como minimo y 9 como maximo.
    if (numero >= 0 && numero <= 9) contUnaCifra += 1;
    // 2 cifras es de 10 como minimo y 99 como maximo. 
    if(numero >= 10 && numero <= 99) contDosCifra += 1;
   }

   Console.WriteLine("1 Cifra >>> " + contUnaCifra + " ||  2 Cifras >>> " + contDosCifra);
   Console.ReadKey();
  }
 }
}
