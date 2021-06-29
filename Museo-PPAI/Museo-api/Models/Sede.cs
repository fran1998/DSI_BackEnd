using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NegocioMuseo.Clases;

namespace Museo_api.Models
{
    public class Sede
    {
        public Sede(int? cantMaxVisitantes, int? cantMaxPorGuia, string nombre, int id)
        {
            _ = new NegocioMuseo.Clases.Sede(cantMaxVisitantes, cantMaxPorGuia, nombre, id);
        }
        public Sede()
        {
            
        }
    }
}