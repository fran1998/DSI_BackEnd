using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{
    public class Obra
    {
        public Nullable<int> Alto { get; set; }
        public Nullable<int> Ancho { get; set; }
        public Nullable<int> CodigoSensor { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaPrimerIngreso { get; set; }
        public string NombreObra { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<int> Valuacion { get; set; }
        public Nullable<System.TimeSpan> DuracionExtendida { get; set; }
        public Nullable<System.TimeSpan> DuracionResumida { get; set; }
        public int Id { get; set; }

    }
}
