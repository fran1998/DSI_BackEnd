using Datos_Museo_PPAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{

    public  class TipoVisita
    {
        public TipoVisita(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Nombre { get; set; }
        public int Id { get; set; }

        public static List<TipoVisita> GetNombre()
        {
            List<TipoVisitas> listEntity = new List<TipoVisitas>();
            List<TipoVisita> listTipoVisita = new List<TipoVisita>();
            using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
            {
                listEntity =  db.TipoVisitas.ToList();
            }
            foreach (var item in listEntity)
            {
                listTipoVisita.Add(new TipoVisita(item.nombre,item.id));
            }
            return listTipoVisita;
        }
    }
}
