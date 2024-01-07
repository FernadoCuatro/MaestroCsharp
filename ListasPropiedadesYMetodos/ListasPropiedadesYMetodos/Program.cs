using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasPropiedadesYMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente oCliente1 = new Cliente("Pedro","Garcia","Romero",17,"ABC Peru");
            Cliente oCliente2 = new Cliente("Luis", "De la Cruz", "Garma", 19, "CDE Peru");
            Cliente oCliente3 = new Cliente("Jorge", "Peceros", "Aurelio", 21, "OUI Peru");
            Cliente oCliente4 = new Cliente("Lucho", "Carmona", "Pedrito", 28, "WER Peru");
            Cliente oCliente5 = new Cliente("Jesus", "Valle", "Roldan", 36, "RTY Peru");

            List<Cliente> listaCLientes = new List<Cliente>
            {
                oCliente1,oCliente2,oCliente3,oCliente4,oCliente5
            };

            listaCLientes.Add(new Cliente("Nelly","Sarmiento","Garcia",40,"DER"));

            List<Cliente> listaCLientes2 = new List<Cliente>
            {
            new Cliente("Adrian","Ugarriza","Perez",20,"peo"),
            new Cliente("Rodrigo","Cuba","Affonso",25,"oia"),
            };

            // El add nos permite agregar solo un objeto
            // El addRange nos permite agregar una lista de objetos, permite agregar una lista a otra lista
            // InsertRange insertamos en un indice especifico
            listaCLientes.InsertRange(2,listaCLientes2);

            // Para eliminar todos los datos de una lista es
            // listaCLientes.Clear();

            // Se elimina un objeto de la lista con el determinado indice
            listaCLientes.RemoveAt(0);

             foreach(Cliente oCliente in listaCLientes)
            {
                Console.WriteLine(oCliente.nombre);
            }

            Console.ReadLine();

        }
    }
}
