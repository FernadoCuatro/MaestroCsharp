using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQOrderBy
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   string[] nombres = {"Jorge", "Aldair", "Pedro", "Luis"};

   // Definicion de la consulta
   var consulta = from nombre in nombres
                  // where nombre.Contains("i")
                  orderby nombre // descending //
                  select nombre;

   // Ejecucion de nuestra consulta
   foreach (string item in consulta)
   {
    Console.WriteLine(item);
   }

   Console.ReadKey();
  }
 }
}
