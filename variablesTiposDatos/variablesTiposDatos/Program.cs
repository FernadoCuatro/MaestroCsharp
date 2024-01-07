using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesTiposDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos
            // Enteros
            short a = 20; // De -32,768 a 32,768
            int b = 39000; // De -2,147,483,648 a 2,147,483,648
            long c = 10000000000000; // De -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807

            // El que consume menos datos, consume menos memoria
            // Entre mas pequeño es mejor, porque se utiliza menos memoria

            // Decimales | Los decimales tambien soportan enteros
            float d = 3012.6f; // Almacena numeros y decimales (7 digitos)
            double e = 1452.53d; // Almacena numeros y decimales (15-16 digitos) | La d es opcional
            decimal f = 123123.5234m; // Almacena numeros y decimales (28-29 digitos)

            // Cadena de texto
            char digito = 'f'; // Soporta un caracter, tiene que ir con comillas simples. 
            string cadena = "Fernando Cuatro Rivera";

            // T or F
            bool exito = false;

            Console.WriteLine(cadena);
            Console.ReadLine();
        }
    }
}
