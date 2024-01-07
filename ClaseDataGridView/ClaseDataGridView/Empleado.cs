using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDataGridView
{
 class Empleado
 {
  public string nombre;
  public double sueldo;
  public int diasTrabajoMes;


  public string nombreEmpleado
  {
   get { return nombre; }
   set { nombre = value; }
  }

  public double sueldoEmpleado
  {
   get { return sueldo; }
   set { sueldo = value; }
  }

  public int trabajoMesEmpleado
  {
   get { return diasTrabajoMes; }
   set { diasTrabajoMes = value; }
  }


 }
}
