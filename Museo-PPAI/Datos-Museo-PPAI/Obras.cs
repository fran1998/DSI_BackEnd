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
    
    public partial class Obras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obras()
        {
            this.DetallesExposiciones = new HashSet<DetallesExposiciones>();
        }
    
        public Nullable<int> alto { get; set; }
        public Nullable<int> ancho { get; set; }
        public Nullable<int> codigoSensor { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaPrimerIngreso { get; set; }
        public string nombreObra { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<int> valuacion { get; set; }
        public Nullable<System.TimeSpan> duracionExtendida { get; set; }
        public Nullable<System.TimeSpan> duracionResumida { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesExposiciones> DetallesExposiciones { get; set; }
    }
}