using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Siempre hay que agregar el using System.Collections; arriba
            ArrayList cursos = new ArrayList();
            cursos.Add("Matematicas");
            cursos.Add("Comunicacion");
            cursos.Add("Lenguaje");
            cursos.Add(50);
            cursos.Add(45.6);

            // Ingresas en la posicion [0]
            cursos.Insert(0, "Educacion Fisica");
  
            foreach(var curso in cursos)
            {
                Console.WriteLine(curso);
            }

            /*
            Console.WriteLine("Numero de elementos " + cursos.Count);
            Console.WriteLine("Primer valor " + cursos[0]);
            */
            Console.ReadLine();

        }
    }
}
