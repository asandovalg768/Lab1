using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Publicaciones
{
    public class Comentario 
    {
        public string texto { set; get; }
        public DateTime fecha { set; get; }
        public int idComentario { set; get; }
        public int idPublicacion { set; get; }
        public string nombreUsuario { set; get; }


     
       

    }
}
