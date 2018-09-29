using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta Debito = new Debito("Alejandro", 1, 5000);
            Cuenta Credito = new Credito("Alejandro", 2, 0);

            Console.WriteLine(PrintCuenta(Debito));
            Console.WriteLine(PrintCuenta(Credito));
            
           // Console.WriteLine(Venta());
            

            Console.ReadKey();


        }

        private static string PrintCuenta(Cuenta c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(c);
            sb.AppendLine();
            sb.Append(c.GetDatos());

            return sb.ToString();
        }


        /*
        public Venta(){
            int monto = Console.Read("Digite el monto de la compra: ");
            int opcion = Console.Read("Digite el tipo de cuenta: 1. Debito \n 2. Credito");
            switch(opcion){
                case 1: 
                    if (Debito(fondos) < plata){
                        Console.WriteLine("Fondos insuficientes");
                    }else{
                        int total = Debito(fondos) - plata;
                        Console.WriteLine("Su total es: " + total);
}

                break;
                case 2:
                     int total = Credito(fondos) - plata;
                        Console.WriteLine("Su total es: " + total);
                break;
                default:
                Console.WriteLine("No existe la opcion");
                break;
}

}
*/

    }
}
