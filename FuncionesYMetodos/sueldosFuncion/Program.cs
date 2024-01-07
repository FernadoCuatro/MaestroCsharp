using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldosFuncion
{
 class Program
 {
  static void Main(string[] args)
  {
   double sueldo = 16.50;

   Console.WriteLine("Semana: " + sueldoSemanal(sueldo));
   Console.WriteLine("Mes: " + sueldoMensual(sueldo));
   Console.WriteLine("Anio: " + sueldoAnual(sueldo));

   Console.ReadKey();
  }
  // Pago semanal (7 dias)
  static double sueldoSemanal(double a){
   return a * 7;
  }
  // Pago mensual (30 dias)
  static double sueldoMensual(double a)
  {
   return a * 30;
  }
  // Pago anual (365 dias)
  static double sueldoAnual(double a)
  {
   return a * 365;
  }
 }
}
