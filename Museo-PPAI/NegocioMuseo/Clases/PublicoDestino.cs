using Datos_Museo_PPAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{
    public class PublicoDestino
    {
        public PublicoDestino(string caracteristicas, string nombre, int id)
        {
            this.Caracteristicas = caracteristicas;
            this.Nombre = nombre;
            this.Id = id;
        }
        public string Caracteristicas { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }

        public string GetNombre()
        {
            return this.Nombre;
        }
    }
}
