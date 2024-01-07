using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTeoria
{
 class Program
 {
  static void Main(string[] args)
  {
   // Definicion de un array, un array debe tener el mismo tipo de dato, ya sea string, o int o float
   String[] marcas = { "Toyota", "Nissan", "Mazda", "Honda", "Hundai", "Porche", "Audi", "Kia" };
   int longMarcas = marcas.Length;  //Contamos los elementos de un array 
   // Recorremos un array con un for
   //for (int i = 0; i < marcas.Length; i++) { Console.WriteLine(marcas[i]); }

   String[] modelos = { "Sentra", "Runner", "Matrix", "Aveo", "Civic", "Picanto", "Frontier", "Hilux" };
   // Recorremos un array con un foreach que pasa esto se invento
   //foreach (String modelo in modelos) { Console.WriteLine(modelo); }
   // Para sacar el ultimo de un array es marcas[marcas.Length - 1];

   // Ejemplo con decimal, estatico y dinamico. 
   double[] notas = { 9.3, 10, 8, 8.2, 10};
   //Console.WriteLine("Las unidades de valoracion son: " + notas.Length );
   //Console.WriteLine("La primer nota es: " + notas[0]);
   //Console.WriteLine("La ultima nota es: " + notas[notas.Length - 1] );

   //Otra forma de definir un array
   int[] anios = new int[5];
   anios[0] = 2016;
   anios[1] = 2017;
   anios[2] = 2018;
   anios[3] = 2019; 
   anios[4] = 2020;

   // Definicion de una Matriz con el array
   String[,] contactos = {
    //La longitud de los array debe de ser la misma para las tres
    //Los tres tienen tres casillas de datos
    {"Julio", "Nieves", "Sandoval"},
    {"Ricardo", "De la Cruz", "Murayari"},
    {"Rolando", "Garcia","Pezero"}
   };
   //Console.WriteLine(contactos[0,2]);

   //Asignando valores
   //estaticos
   int[] numero = new int[4];
   //anios[0] = 10;
   //anios[1] = 20;
   //anios[2] = 30;
   //anios[3] = 40;

   int[] numero = new int[4];
   numero[0] = 10;
   numero[1] = 20;
   numero[2] = 30;
   numero[3] = 40;

   //Dinamicos
   for(int i=0; i< 4; i++){
    Console.Write("Ingrese numero " + (i+1) + " => ");
    int vlrNumero = Convert.ToInt32(Console.ReadLine());
    numero[i] = vlrNumero;
   }

  int[] numero = new int[4];
   numero[0] = 10;
   numero[1] = 20;
   numero[2] = 30;
   numero[3] = 40;

   Console.Write("for: ");
   for(int i=0; i< numero.Length; i++){
   	Console.Write(" | " +numero[i] + " | ");
   }

   Console.Write("foreach: ");
   foreach(int num in numero){
    Console.Write(" | " +num + " | ");
   }

   Console.ReadLine();
  }
 }
}
