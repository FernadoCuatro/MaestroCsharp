//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiPrimeraAplicacionEscritorio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int IIDUSUARIO { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CONTRA { get; set; }
        public string TIPOUSUARIO { get; set; }
        public Nullable<int> IID { get; set; }
        public Nullable<int> IIDROL { get; set; }
        public Nullable<int> bhabilitado { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual TIPOUSUARIOREGISTRO TIPOUSUARIOREGISTRO { get; set; }
    }
}
