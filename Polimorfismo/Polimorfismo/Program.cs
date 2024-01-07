using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.nombre = "Julio";
            per.apPaterno = "Fernandez";
            per.apMaterno = "Felipe";

            Persona oPersona1 = new Empleado();

            Persona oPersona2 = new Cliente();
        }
    }
}
