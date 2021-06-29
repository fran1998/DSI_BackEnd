using Datos_Museo_PPAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMuseo.Clases
{
    public class GestorRegistrarReserva
    {
        private static GestorRegistrarReserva gestorRegistrarReserva;
        private System.TimeSpan duracionReserva = new System.TimeSpan();
        private GestorRegistrarReserva() { }

        public static GestorRegistrarReserva GetInstance()
        {
            if (gestorRegistrarReserva == null)
            {
                gestorRegistrarReserva = new GestorRegistrarReserva();
            }
            return gestorRegistrarReserva;
        }
        public List<Escuela> ObtenerEscuela()
        {
            return Escuela.GetNombre();
        }
        public List<Sede> ObtenerSede()
        {
            return Sede.GetNombre();
        }
        public List<TipoVisita> ObtenerTipoVisita()
        {
            return TipoVisita.GetNombre();
        }

        public List<Exposicion> ObtenerExposicionesTemporalesVigentesDeSede(Sede sede)
        {
            return sede.ObtenerExposicionesVigentes();
        }
        public void CalcularDuracionReserva(List<int> listExposiciones)
        {
            duracionReserva = Exposicion.CalcularDuracionExposicion(listExposiciones);
        }
    }
}
