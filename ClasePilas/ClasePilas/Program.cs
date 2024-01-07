using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ClasePilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilas = new Stack();
            pilas.Push("Lunes");
            pilas.Push("Martes");
            pilas.Push("Miercoles");
            pilas.Push("Jueves");
            pilas.Push("Viernes");
            pilas.Push("Sabado");
            pilas.Push("Domingo");

            // Borro todos los elementos
            // pilas.Clear();
            string[] diasSemana = new string[7];

            // Copias los elementos de la pila a un array
            pilas.CopyTo(diasSemana, 0);

            // Elimina el elemento desde arriba, uno por uno
            pilas.Pop();
            pilas.Pop();

            foreach(string pila in pilas)
            {
                Console.WriteLine(pila);
            }

            // Contamos la cantidad de elementos que tiene 
            Console.WriteLine("El numero de elementos es " + pilas.Count);

            /*
            foreach(var item in pilas)
            {
                Console.WriteLine(item);
            }
            */
            Console.ReadLine();


        }
    }
}
