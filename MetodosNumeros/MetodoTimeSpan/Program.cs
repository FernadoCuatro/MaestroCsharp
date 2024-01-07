using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan fecha1 = new TimeSpan(15, 12, 15, 15, 15);
            TimeSpan fecha2 = new TimeSpan(5, 48, 15, 45, 45);
            TimeSpan fech3 = new TimeSpan(1, 48, 15, 45, 45);

            string fecha = "17:20:10";

           Console.WriteLine( TimeSpan.ParseExact(fecha, @"h\:mm\:ss",null));

            /*
            Console.WriteLine(TimeSpan.FromDays(1));
            Console.WriteLine(TimeSpan.FromHours(2));
            Console.WriteLine(TimeSpan.FromMinutes(2));
            Console.WriteLine(TimeSpan.FromSeconds(9));
            Console.WriteLine(TimeSpan.FromMilliseconds(8));

            */

            /*
            TimeSpan fecha1 = new TimeSpan(15, 12, 15, 15, 15);
            TimeSpan fecha2 = new TimeSpan(5, 48, 15, 45, 45);

            TimeSpan fecha3 = fecha1 + fecha2;

                Console.WriteLine("Total de dias " + fecha3.TotalDays);
            Console.WriteLine("Total de horas " + fecha3.TotalHours);
            Console.WriteLine("Total de minutos " + fecha3.TotalMinutes);
            Console.WriteLine("Total segundos " + fecha3.TotalSeconds);
            Console.WriteLine("Total milisegundos " + fecha3.TotalMilliseconds);
            
            */
            Console.ReadLine();


            /*
            TimeSpan fecha1 = new TimeSpan(10, 13, 5, 2, 10);
            TimeSpan fecha2 = new TimeSpan(5, 4, 5, 4, 7);

            TimeSpan fecha3 = fecha1 + fecha2;

            Console.WriteLine("Total days " + fecha3.TotalDays);
            Console.WriteLine("Total horas " + fecha3.TotalHours);
            Console.WriteLine("Total minutos " + fecha3.TotalMinutes);
            Console.WriteLine("Total segundos " + fecha3.TotalSeconds);
            Console.WriteLine("Total mlisegundos" + fecha3.TotalMilliseconds);
            */
            /*
            TimeSpan objeto1 = new TimeSpan(12,10,5,12,18);
            //                              day h m s   ms
            Console.WriteLine("Hora :" + objeto1.Hours);
            Console.WriteLine("DIa " + objeto1.Days);
            Console.WriteLine("Minutos " + objeto1.Minutes);
            Console.WriteLine("Segundos " + objeto1.Seconds);
            Console.WriteLine("Milisegundos " + objeto1.Milliseconds);
            
            */
            Console.ReadLine();

            /*
            TimeSpan objeto1 =new  TimeSpan(4,10,29);
            TimeSpan objeto2 = new TimeSpan(5, 15, 10);

            TimeSpan objeto3 = objeto1 + objeto2;
            TimeSpan objeto4 = objeto2 - objeto1;
            Console.WriteLine("Suma" +objeto3);
            Console.WriteLine("Resta " + objeto4);
            Console.ReadLine();
           */
        }
    }
}
