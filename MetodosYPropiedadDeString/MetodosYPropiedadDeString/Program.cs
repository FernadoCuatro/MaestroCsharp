using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosYPropiedadDeString
{
 class Program
 {
  static void Main(string[] args)
  {
   // Contador de caracteres de una palabra 
   String nombre = "Roberto";
   Console.WriteLine(nombre.Length);

   // Revisar si dos cadenas son iguales
   String a = "Mama", b = "Papa";
   if (a.Equals(b)){
    Console.WriteLine("Son iguales las palabras");
   }else{
    Console.WriteLine("Son diferentes las palabras");
   }

   Console.ReadKey();
  }
 }
}
