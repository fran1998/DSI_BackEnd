using NegocioMuseo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Museo_api.Controllers
{

    public class GestorController : ApiController
    {
        readonly GestorRegistrarReserva gestorRegistrarReserva = GestorRegistrarReserva.GetInstance();


        [Route("api/Gestor/Escuela")]
        public IHttpActionResult GetEscuela()
        {
            return Ok(gestorRegistrarReserva.ObtenerEscuela());
        }

        [Route("api/Gestor/Sede")]
        public IHttpActionResult GetSede()
        {
            return Ok(gestorRegistrarReserva.ObtenerSede());
        }

        [Route("api/Gestor/TipoVisita")]
        public IHttpActionResult GetTipoVisita()
        {
            return Ok(gestorRegistrarReserva.ObtenerTipoVisita());
        }
        ///https//localhost:44352/apiGestor/ObtenerExposicionesDeSede/350/15/Centro/1
        [Route("api/Gestor/ObtenerExposicionesDeSede/{sede.CantMaxVisitantes:int?}/{sede.CantMaxPorGuia:int?}/{sede.Nombre}/{sede.Id}")]
        [HttpGet]
        public IHttpActionResult ObtenerExposicionesDeSede([FromUri] Sede sede )
        {
            return Ok(gestorRegistrarReserva.ObtenerExposicionesTemporalesVigentesDeSede(sede));
        }
        //
        //Gótico 1 //Arte Medieval  3
        [Route("api/Gestor/CalcularDuracionObra/{listExposicion}")]
        [HttpGet]
        public void CalcularDuracionObra([FromUri] List<int> listExposicion)
        {
            gestorRegistrarReserva.CalcularDuracionReserva(listExposicion);
        }
    }
}
