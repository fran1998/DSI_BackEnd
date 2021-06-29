using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Museo_PPAI;

namespace NegocioMuseo.Clases
{
    public class TipoExposicion
    {
        public TipoExposicion(string nombre, string descripcion, int id)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Id = id;
        }
        public TipoExposicion(int id)
        {
            TipoExposiciones entity;
            using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
            {
                entity = db.TipoExposiciones.Where(tipoexp => tipoexp.id == id).FirstOrDefault();
            }
            this.Nombre = entity.nombre;
            this.Id = entity.id;
            this.Descripcion = entity.descripcion;
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }

        public string GetNombre()
        {
            return this.Nombre;
        }
    }
}
