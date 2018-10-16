using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Publicaciones
{
    public class Comentario 
    {
        public string texto { get; set; }
        public DateTime fecha { get; set; }
        public int idComentario { get; set; }
        public int idPublicacion { get; set; }
        public string nombreUsuario { get; set; }


     
       

    }
}
