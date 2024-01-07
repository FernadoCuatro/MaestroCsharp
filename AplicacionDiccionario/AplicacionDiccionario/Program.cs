using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDiccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1  (Domingo)
            //2  (Lunes)
            //3 (Martes)

            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            diccionario[7] = "Sabado";
            diccionario[8] = "Enero";


            //diccionario.Clear();
            diccionario.Remove(8);

           
            foreach(string val in diccionario.Values)
            {
                Console.WriteLine(val);
            }
             
            Console.WriteLine("El numero de elementos es " + diccionario.Count);

            Console.ReadLine();
        }
    }
}
