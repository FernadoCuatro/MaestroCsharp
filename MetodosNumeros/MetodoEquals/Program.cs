using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;
            if (a.Equals(b))
            {
                Console.WriteLine("Son iguales");

            }else
            {
                Console.WriteLine("SOn diferentes");

            }

            Console.ReadLine();
        }
    }
}
