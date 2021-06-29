using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{
    public class DetalleExposicion
    {
        public DetalleExposicion(int? idObra, int? idExp, int? lugarAsignado, int id, Obra obra)
        {
            this.idObra = idObra;
            IdExp = idExp;
            LugarAsignado = lugarAsignado;
            Id = id;
            Obra = obra;
        }

        public Nullable<int> idObra { get; set; }
        public Nullable<int> IdExp { get; set; }
        public Nullable<int> LugarAsignado { get; set; }
        public int Id { get; set; }
        public Obra Obra { get; set; }
    }

}
