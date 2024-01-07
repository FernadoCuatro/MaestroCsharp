using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01Herencia
{
   public abstract class Empleado
    {
        //readonly te indica es una constancia
        public readonly int PLUS = 400;

        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }

        public  abstract double plus();

    }
}
