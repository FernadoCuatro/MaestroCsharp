using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
 class Program
 {
  static void Main(string[] args)
  {
   m("Hola, que tal");

   x();
  }
  static void m(string a){
   Console.WriteLine(a);
  }

  static void x(){
   Console.ReadKey();
  }


 }
}
