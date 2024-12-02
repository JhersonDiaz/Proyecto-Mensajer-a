using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proycto_Mensajeria.Clases
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime Fecha { get; set;}
        public String NombreReceptor { get; set; }
        public string Respuesta { get; set;}


        //Constructor
        public Usuario(int id, string nombre, string Correo, string nombrereceptor,string respuesta)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = Correo;
            Fecha = DateTime.Now;
            NombreReceptor = nombrereceptor;
            Respuesta = respuesta;
        }

        public Usuario(int id, string nombre, string Correo, string nombrereceptor, string respuesta, string text) : this(id, nombre, Correo, nombrereceptor, respuesta)
        {
        }

        public override string ToString()
        {
            return $"Id:{Id},Nombre:{Nombre},CorreoElectronico:{CorreoElectronico},Fecha:{Fecha},NombreReceptor:{NombreReceptor},Respuesta:{Respuesta}";
        }
    }
   
}
