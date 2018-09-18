using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1
{
    public class Persona:ILogger
    {
        public Persona()
        {
        }

        public Persona(string nombre, int id, string apellido)
        {
            Nombre = nombre;
            Id = id;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Apellido { get; set; }

        public void Log(string log)
        {
            System.Console.WriteLine("Usuario desea ingresar");
        }
    }
}
