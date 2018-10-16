using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Publicaciones
{
    class Menu
    {

        // Inicializacion de variables y listas
        List<Usuario> listaUsuarios = new List<Usuario>();
        List<Publicacion> listaPublicaciones = new List<Publicacion>();
        List<Comentario> listaComentario = new List<Comentario>();

        string nombreUsuario;
       
        public void MenuPrincipal()
        {
   
            int idPublicacion = 0;
            int salir = 2;

            while (salir == 2)
            {
                LogicaUsuario(); // Llama al metodo donde se piden los datos al usuario
 
                int salirPubli = 2;
                int salirComent = 2;
                int recorre = 0;

                Console.WriteLine("Digite un tipo de usuario: \n1. Editor \n2. Invitado"); // se escoje el tipo de usuario que desea ser 
                int tipoUsuario = Convert.ToInt32(Console.ReadLine());
                switch (tipoUsuario) 
                {
                    case 1:
                        while (salirPubli == 2)
                        {
                            Console.WriteLine("Digite lo que desea realizar: \n1. Nueva publicacion \n2. Lista de Publicaciones");
                            int accionPubli = Convert.ToInt32(Console.ReadLine());
                            if (accionPubli == 1)
                            {
                                Console.WriteLine("Digite lo que quiere publicar: "); 
                                string texto = Console.ReadLine();   
                                idPublicacion++; // Identificador para comentar
                                listaPublicaciones.Add(new Publicacion { idPublicacion = idPublicacion, nombreUsuario = nombreUsuario, fecha = DateTime.Now, texto = texto }); // Pide los datos al usuario y los agrega a la lista

                            }
                            else
                            {
                                Imprimir(); // llama al metodo imprimir
                            }
                            Console.WriteLine("Desea salir: \n 1. Si \n 2. No");
                            salirPubli = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 2:
                        while (salirComent == 2)
                        {
                            Console.WriteLine("Digite lo que desea realizar: \n1. Nuevo comentario \n2. Lista de Publicaciones"); 
                            int accionComent = Convert.ToInt32(Console.ReadLine());
                            if (accionComent == 1)
                            {
                                Console.WriteLine("Digite el número de la publicación:");
                                int numPublicacion = Convert.ToInt32(Console.ReadLine());
                              

                                for (int i = 0; i < listaPublicaciones.Count; i++) // Recorre la lista
                                {
                                    if (listaPublicaciones[i].idPublicacion == numPublicacion) // Condicion que evalua si el numero de la publicacion esta dentro de la lista
                                    {
                                        Console.WriteLine("Digite lo que quiere publicar:");
                                        string texto = Console.ReadLine();
                                        int idComentario = 0;
                                        idComentario++; 
                                        recorre++;
                                        listaComentario.Add(new Comentario { idComentario = idComentario, nombreUsuario = nombreUsuario, idPublicacion = idPublicacion, fecha = DateTime.Now, texto = texto }); // Pide los datos al usuario y los agrega a la lista


                                    }
                                
                                if (recorre == 0)
                                    {
                                        Console.WriteLine("No existe la opcion");
                                        Console.ReadLine();
                                    }

                                }

                            }
                            else
                            {
                                Imprimir(); // Se llama al metodo imprimir
                            }
                            Console.WriteLine("Desea salir: \n 1. Si \n 2. No");
                            salirComent = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;


                }
                Console.WriteLine("Desea cerrar el programa: \n 1. Si \n 2. No ");
                salir = Convert.ToInt32(Console.ReadLine());
            }

        }


        public void LogicaUsuario()
        {
            // Pide los datos al usuario y los agrega a la lista
            Console.WriteLine("Digite su nombre: ");
            nombreUsuario = Console.ReadLine();
            
           
            listaUsuarios.Add(new Usuario { nombreUsuario = nombreUsuario});
        }


        public void Imprimir()
        {
            //Imprime las listas
            for (int i = 0; i < listaPublicaciones.Count; i++)
            {
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("Publicación el : " + listaPublicaciones[i].fecha);
                Console.WriteLine(" " + listaPublicaciones[i].texto);
                Console.WriteLine("Por: " + listaPublicaciones[i].nombreUsuario);
                Console.WriteLine("\n------------------------------------------------------------");

                for (int j = 0; j < listaComentario.Count; j++)
                {
                    if (listaComentario[j].idPublicacion == i + 1)
                    {
                        Console.WriteLine("\n------------------------------------------------------------");
                        Console.WriteLine("Comentario el: " + listaComentario[j].fecha);
                        Console.WriteLine("" + listaComentario[j].texto);
                        Console.WriteLine("Por: Invitado " + listaComentario[j].nombreUsuario);
                        Console.WriteLine("\n------------------------------------------------------------");
                    }
                }

            }
        }


        




    }



}

