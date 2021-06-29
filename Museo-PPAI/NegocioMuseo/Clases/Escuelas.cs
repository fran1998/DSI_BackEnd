using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Museo_PPAI;
namespace NegocioMuseo.Clases
{
    public class Escuela 
    {
        public Escuela(string domicilio, string mail, string nombre, string telefCelular, string telefFijo, int id)
        {
            this.Domicilio = domicilio;
            this.Mail = mail;
            this.Nombre = nombre;
            this.TelefCelular = telefCelular;
            this.TelefFijo = telefFijo;
            this.Id = id;
        }

        public string Domicilio { get; set; }
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string TelefCelular { get; set; }
        public string TelefFijo { get; set; }
        public int Id { get; set; }

        public static List<Escuela> GetNombre()
        {
            List<Escuelas> listentity = new List<Escuelas>();
            List<Escuela> listescuelas = new List<Escuela>();
            using (DSI_PPAI_MuseoEntities1 db = new DSI_PPAI_MuseoEntities1())
            {
                listentity = db.Escuelas.ToList();
            }
            foreach (var item in listentity)
            {
                listescuelas.Add(new Escuela(item.domicilio, item.mail, item.nombre, item.telefCelular, item.telefFijo, item.id));          
            }
            return listescuelas;
        } 
    }
}
