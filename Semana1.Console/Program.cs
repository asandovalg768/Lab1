using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Persona");

        


            Persona persona = new Persona();
            persona.Id = 1;
            persona.Nombre = "Alejandro";
            persona.Apellido = "Sandoval";
            ILogger logger = persona;


          
            string personString = string.Format("Id:{0}, Nombre: {1}, Apellido: {2}", persona.Id, persona.Nombre, persona.Apellido);
            System.Console.WriteLine(personString);
            logger.Log("Hola Mundo");
            System.Console.ReadKey();
        }
    }
}
