//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos_Museo_PPAI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public Nullable<System.DateTime> caducidad { get; set; }
        public int id { get; set; }
        public Nullable<int> empleado { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}
