using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Credito : Cuenta
    {
        private string v1;
        private string v2;
        private int Fondos;

        public Credito(string nombre, int numero, int fondos) : base(nombre, numero)
        {
            this.Fondos = fondos;
        }

        public override string GetDatos()
        {
            return "Credito: " + base.GetDatos() + " Fondos:" + Fondos;
        }
    }
}

