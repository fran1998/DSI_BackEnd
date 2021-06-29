using Datos_Museo_PPAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{
    public class Sede
    {
        public Sede(int?cantMaxVisitantes, int? cantMaxPorGuia, string nombre, int id)
        {
            this.CantMaxVisitantes = (int)cantMaxVisitantes;
            this.CantMaxPorGuia = (int)cantMaxPorGuia;
            this.Nombre = nombre;
            this.Id = id;
        }
        public Sede()
        {
            
        }
        public int CantMaxVisitantes { get; set; }
        public int CantMaxPorGuia { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }

        public static List<Sede> GetNombre()
        {
            List<Sede> Listsede = new List<Sede>();
            List<Sedes> listEntity = new List<Sedes>();
            using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
            {
                listEntity = db.Sedes.ToList();
            }
            foreach (var item in listEntity)
            {
                Listsede.Add(new Sede(item.cantMaxVisitantes, item.cantMaxPorGuia, item.nombre, item.id));
            }
            return Listsede;
        }

        public List<Exposicion> ObtenerExposicionesVigentes()
        {
            return Exposicion.ValidarVigenciaExposicion(this.Id);
        }
    }
       
}
