using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Julio";
            emp.apPaterno = "Fernandez";
            emp.apMaterno = "Felipe";
            emp.sueldo = 3000;
            emp.fechaContrato = DateTime.Now;
           string nombreCompleto=  emp.nombreCompleto();
            Console.WriteLine(nombreCompleto);
            Console.WriteLine("Fecha de contrato " + emp.fechaContrato + " sueldo " + emp.sueldo);


            Cliente oCLiente = new Cliente();
            oCLiente.nombre = "Joseph";
            oCLiente.apPaterno = "De la Cruz";
            oCLiente.apMaterno = "Aurelio";
            oCLiente.edad = 22;
            oCLiente.direccion = "ABC";
            oCLiente.fechaNacimiento = DateTime.Now;

            string nombreComp= oCLiente.nombreCompleto();
            Console.WriteLine(nombreComp);


            Console.ReadLine();
        }
    }
}
