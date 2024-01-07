using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQOrderByListas
{
 class Program
 {
  static void Main(string[] args)
  {
   // Fuente de datos
   List<Persona> listaPersona = new List<Persona>
   {
    new Persona {idPersonaPersona=1 , nombrePersona="Julio", apellidoPersona="Perez" },
    new Persona {idPersonaPersona=2 , nombrePersona="Jorge", apellidoPersona="Jimenez" },
    new Persona {idPersonaPersona=3 , nombrePersona="Lucho", apellidoPersona="Almeida" },
   };

   // Definimos nuestra consulta
   var consulta = from persona in listaPersona
                  orderby persona.apellidoPersona
                  select persona;

   // Recorremos la solucion
   foreach (var item in consulta)
   {
    Console.WriteLine($"La persona {item.nombrePersona} con apellido {item.apellidoPersona}");
   }

   Console.ReadKey();
  }
 }
}
