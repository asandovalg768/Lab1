using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Debito : Cuenta
    {
        private int Fondos;

        public Debito(string nombre, int numero, int fondos) : base(nombre, numero)
        {
            this.Fondos = fondos;
        }

        public override string GetDatos()
        {
            return "Debito: " + base.GetDatos() + " Fondos:" + Fondos;
        }
    }
}