using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2Condiciones
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   int[] numeros = { 11, 15, 17, 19, 14, 18 };

   // Defnicion de la consulta
   var consulta = from edad in numeros
                  where edad > 12 && edad < 17
                  select edad;

   foreach (int edad in consulta)
   {
    Console.WriteLine(edad);
   }

   Console.ReadKey();
  }
 }
}



    if (consulta.Equals())
    {
     MessageBox.Show("Se guardaron los datos", "Exito");
    }
    else
    {
     MessageBox.Show("No se completo el proceso", "Error");
    }