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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.AsignacionesVisitas = new HashSet<AsignacionesVisitas>();
            this.Usuarios = new HashSet<Usuarios>();
            this.HorariosEmpleados = new HashSet<HorariosEmpleados>();
        }
    
        public Nullable<int> sede { get; set; }
        public string apellido { get; set; }
        public int cuit { get; set; }
        public Nullable<int> dni { get; set; }
        public Nullable<int> codigoVerificacion { get; set; }
        public string domicilio { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public Nullable<int> cargo { get; set; }
        public string horario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignacionesVisitas> AsignacionesVisitas { get; set; }
        public virtual Cargos Cargos { get; set; }
        public virtual Sedes Sedes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorariosEmpleados> HorariosEmpleados { get; set; }
    }
}
