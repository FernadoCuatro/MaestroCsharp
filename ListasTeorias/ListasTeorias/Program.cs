using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasTeorias
{
 class Program
 {
  static void Main(string[] args)
  {
   // Definimos una lista de tipo string
   List<string> listaNombres = new List<string>();
   // Llenamos esa lista con el Add
   listaNombres.Add("Fernando");
   listaNombres.Add("Miguel");
   listaNombres.Add("Melissa");
   listaNombres.Add("Alexandra");
   listaNombres.Add("Estefany");
   listaNombres.Add("Elizabeth");

   // Recorremos los datos en esta lista
   Console.WriteLine("Desplegamos la informacion");
   foreach (string nombre in listaNombres)
   {
    Console.WriteLine(nombre);
   }

   // Contamos cuantos elementos tiene una lista 
   Console.WriteLine("\nLa dimension de la lista donde estan los nombres es de: " + listaNombres.Count);

   // =========================================================
   Console.Write("\n=========================================================\n");
   // =========================================================

   Estudiante oEstudiante = new Estudiante("Elizabeth", 9, 10);
   Estudiante oEstudiante1 = new Estudiante("Sofia", 7, 8);
   Estudiante oEstudiante2 = new Estudiante("Melissa", 10, 10);

   List<Estudiante> listaEstudiante = new List<Estudiante>
   {
    oEstudiante, oEstudiante1, oEstudiante2, new Estudiante("Fernando", 7, 8), new Estudiante("Angel", 10, 10), new Estudiante("Luis", 9, 10)
   };

   List<Estudiante> listaEstudiante1 = new List<Estudiante>();
   listaEstudiante1.Add(new Estudiante("Ana", 7, 8));

   // El addRange nos permite agregar mas de un dato a una lista determinada, puede ser una lista a otra lista
   listaEstudiante.AddRange(listaEstudiante1);

   foreach (Estudiante estudiante in listaEstudiante)
   {
    Console.WriteLine(estudiante.nombre);
   }


   Console.ReadKey();
  }
 }
}
