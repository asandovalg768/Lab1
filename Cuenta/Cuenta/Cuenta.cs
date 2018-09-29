using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Cuenta
    {
        public string Tipo { set; get; }
        public string Nombre { set; get; }
        public int Numero { set; get; }

        public Cuenta( string nombre, int numero)
        {
            this.Nombre = nombre;
            this.Numero = numero;

        }

        public virtual string GetDatos()
        {
            return Nombre + " " + Tipo + " " + Numero;
        }

    }
}
