using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    //Superclase (POr que de esta van a heredar sus hijos las propiedades
    // y los metodos)
   public class Persona
    {
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public int edad { get; set; }

        public string nombreCompleto()
        {
            return this.nombre + " " + this.apPaterno + " " + this.apMaterno;
        }

    }
}
