using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Suma(+) | Resta(-) | Multiplicacion(*) | Division(/) | Residuo(%)
            int a = 50;
            int b = 40;
            double c = 20.5d;

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = (a * 1.0) / b;
            // Para Csharp cuando una division es con dos enteros, te devolvera un entero; no se complica. 
            // Por eso lo multiplicamos con un decimal, para que nos de un restultado exacto. 
            double residuo = a % b;
            double e = b + c;


            Console.WriteLine("Suma " + suma);
            Console.WriteLine("Resta " + resta);
            Console.WriteLine("Multiplicacion " + multiplicacion);
            Console.WriteLine("Division " + division);
            Console.WriteLine("Residuo " + residuo);
            Console.WriteLine("Suma Doble " + e);
            Console.ReadLine();
        }
    }
}
