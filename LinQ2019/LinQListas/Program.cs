using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQListas
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente
   List<Empleado> listaEmpleado = new List<Empleado>
   {
    new Empleado {idEmpleadoEmpleado = 1, nombreEmpleado="Vanessa", sueldoEmpleado=1000 },
    new Empleado {idEmpleadoEmpleado = 2, nombreEmpleado="Jorge", sueldoEmpleado= 800 },
    new Empleado {idEmpleadoEmpleado = 3, nombreEmpleado="Carmen", sueldoEmpleado=1500 },
    new Empleado {idEmpleadoEmpleado = 4, nombreEmpleado="Aurora", sueldoEmpleado=1200 }
   };

   // Consulta a realizar
   var cosulta = from datos in listaEmpleado
                 where datos.sueldoEmpleado >= 1100
                 select datos;

   // Recorrer la consulta
   foreach (var item in cosulta)
   {
    Console.WriteLine("Nombre: " + item.nombreEmpleado + ", sueldo: "+ item.sueldoEmpleado);
   }

   Console.ReadKey();
  }
 }
}
