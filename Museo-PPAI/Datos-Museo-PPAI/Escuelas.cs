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
    
    public partial class Escuelas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Escuelas()
        {
            this.ReservasVisitas = new HashSet<ReservasVisitas>();
        }
    
        public string domicilio { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string telefCelular { get; set; }
        public string telefFijo { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasVisitas> ReservasVisitas { get; set; }
    }
}
