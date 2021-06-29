using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Museo_PPAI;

namespace NegocioMuseo.Clases
{
    public class Exposicion
    {
        public Exposicion(int? sede, DateTime? fechaFin, DateTime? fechaFinReplanificada, DateTime? fechaInicio, DateTime? fechaInicioReplanificada, string nombre, TimeSpan? horaApertura, TimeSpan? horaCierre, int id, TipoExposicion tipoExposicion , List<PublicoDestino> listPublicoDestino)
        {
            this.Sede = sede;
            this.FechaFin = fechaFin;
            this.FechaFinReplanificada = fechaFinReplanificada;
            this.FechaInicio = fechaInicio;
            this.FechaInicioReplanificada = fechaInicioReplanificada;
            this.Nombre = nombre;
            this.HoraApertura = horaApertura;
            this.HoraCierre = horaCierre;
            this.Id = id;
            this.TipoExposicion = tipoExposicion;
            this.ListPublicoDestino = new List<PublicoDestino>();
            foreach (var item in listPublicoDestino)
            {
                this.ListPublicoDestino.Add(item);
            }
        }
        public Exposicion( string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;

        }
        public Exposicion()
        {
            
        }

        public Nullable<int> Sede { get; set; }

        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.DateTime> FechaFinReplanificada { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaInicioReplanificada { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.TimeSpan> HoraApertura { get; set; }
        public Nullable<System.TimeSpan> HoraCierre { get; set; }
        public int Id { get; set; }
        public TipoExposicion TipoExposicion { get; set; }

        public List<PublicoDestino> ListPublicoDestino { get; set; }
        public List<DetalleExposicion> DetalleExposicion { get; set; }

        public static List<Exposicion> ValidarVigenciaExposicion(int idSede)
        {
            List<Exposiciones> listEntity = new List<Exposiciones>();
            List<Exposicion> listExp = new List<Exposicion>();
            Exposicion exposicion;
            TipoExposicion tipoExposicion;
            List<PublicoDestino> listPublicoDestino = new List<PublicoDestino>();
            using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
            {
                listEntity = db.Exposiciones.Where(expo => expo.sede == idSede).ToList();
                foreach (var item in listEntity)
                {
                    foreach (var itemPD in item.PublicosDestino)
                    {
                        listPublicoDestino.Add(new PublicoDestino(itemPD.caracteristicas, itemPD.nombre, itemPD.id));
                    }
                    tipoExposicion = new TipoExposicion((int)item.tipoExp);
                    exposicion = new Exposicion(item.sede, item.fechaFin, item.fechaFinReplanificada, item.fechaInicio, item.fechaInicioReplanificada,
                        item.nombre, item.horaApertura, item.horaCierre, item.id, tipoExposicion, listPublicoDestino);
                    if (exposicion.EsTemporal())
                    {
                        listExp.Add(exposicion);
                    }
                }
            }
            
            return listExp;
        }

        public bool EsTemporal()
        {
            return (this.TipoExposicion.GetNombre() == "Temporal");
        }
        public System.TimeSpan GetHsCierre()
        {
            return (TimeSpan)this.HoraCierre;
        }
        public System.TimeSpan GetHsInicio()
        {
            return (TimeSpan)this.HoraApertura;
        }
        public static System.TimeSpan CalcularDuracionExposicion(List<int> listExposiciones)
        {
            System.TimeSpan duracionObra = new TimeSpan();
            System.TimeSpan duracionExposicion = new TimeSpan();
            //List<DetalleExposicion> listDetalleExp = new List<DetalleExposicion>();
            List<DetallesExposiciones> listEntity = new List<DetallesExposiciones>();
            foreach (var item in listExposiciones)
            {
                using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
                {
                    listEntity = db.DetallesExposiciones.Where(detalleExp => detalleExp.idExp == item).ToList();
                    foreach (var itemObra in listEntity)
                    {
                        duracionExposicion += duracionObra.Add((TimeSpan)itemObra.Obras.duracionExtendida);

                    }
                }
            }
            return duracionExposicion;
        }
    }


}
