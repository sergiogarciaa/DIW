using System;

namespace RepasoGarciaBarreraSergio // Note: actual namespace depends on the project name.
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            InterfazMenu menu = new ImplementacionMenu();
            bool seguir = true;
            int opcion;

            do
            {
                menu.MostrarMenu();
                Console.WriteLine("Introduzca la opción deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        persona.nuevaPersona(listaPersona);
                        break;
                    case 2:
                        persona.mostrarPersona(listaPersona);
                        break;
                    case 3:
                        seguir = false;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }



            } while (seguir);
        }
    }
}