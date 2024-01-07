using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoComersial
{
 class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine("Ingrese el precio: ");
   double precio = double.Parse(Console.ReadLine());
   double descuento = precio * 0.20d;

   double total = precio - descuento;

   Console.WriteLine("El descuento total es de: " + descuento);
   Console.WriteLine("El total a pagar es: " + total);

   Console.ReadLine();

  }
 }
}
