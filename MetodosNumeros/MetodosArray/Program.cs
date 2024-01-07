using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5,18,21,22,13};
            //                0  1  2 3  4
            string[] nombres = {"Pedro","Luis","Jose","Felipe" };

            /*
            Array.Reverse(numeros);

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */

            /*
            Array.Sort(numeros);

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */

            //El indice del primer elemento mayor a 10
            
            
            /*
           bool exito= Array.Exists(nombres, p => p.StartsWith("J"));
            if (exito)
            {
                Console.WriteLine("Hay elementos que cumplen la condicion");
            }
            else
            {
                Console.WriteLine("No hay elementos");
            }
            */
            /*
           int indiceUltimo=  Array.FindLastIndex(numeros, p => p > 14);
            Console.WriteLine("El indice es " + indiceUltimo);
            Console.WriteLine("El valor es " + numeros[indiceUltimo]);
            */
              /*
            int indice = Array.FindIndex(numeros, p => p > 10);

            Console.WriteLine("El indice es " + indice);
            Console.WriteLine("Su valor es : " + numeros[indice]);
            */
            /*

            int numero= Array.FindLast(numeros, p => p > 20);

            Console.WriteLine("El ultimo elemento es " + numero);


            */
            //int indice = Array.IndexOf(numeros, 21);
            //if (indice > 0)
            //{
            //    Console.WriteLine("Existe el valor");
            //}else
            //{
            //    Console.WriteLine("No existe");
            //}

            //int longitud = numeros.Length;

            //Console.WriteLine("El numero de elementos es " + longitud);

            //Sacar el primer elemento del array que sea mayor 15

            /*
        int mayorA15=    Array.Find(numeros, p => p > 15);

         int[] numerosFiltrados=   Array.FindAll(numeros, el => el > 15);
          foreach(int el in numerosFiltrados)
            {
                Console.WriteLine(el);
            }
            */
            
            //  Console.WriteLine("El primer elemento mayor a 15 es :" + mayorA15);

            Console.ReadLine();



        }
    }
}
