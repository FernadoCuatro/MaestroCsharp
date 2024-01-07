using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMetodo
{
 class Program
 {
  static void Main(string[] args)
  {
   string[] nombres = { "Melissa", "Alexandra", "Ana", "Cecilia" };
   impArray(nombres);

   Console.ReadKey();
  }

  static void impArray(string[] array){

   foreach (string item in array)
   {
    m(item);
   }
  }

  static void m(string a)
  {
   Console.WriteLine(a);
  }


 }
}
