using RepasoGarciaBarreraSergio.Entidades;
using RepasoGarciaBarreraSergio.Servicios;
using System;

namespace RepasoGarciaBarreraSergio // Note: actual namespace depends on the project name.
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            // Inicialización
            List<Empleado> listaEmpleados = new List<Empleado>();
            // Interfaces
            InterfazEscritura escritura = new ImplementacionEscritura();
            InterfazEmpleado empleados = new ImplementacionEmpleado();
            InterfazMenu menu = new ImplementacionMenu();

            // Variables
            bool cerrarMenu = false;
            int opcion;

            // Menú
            while (!cerrarMenu)
            {
                // Mostramos el menú
                menu.MostrarMenu();
                Console.WriteLine("Introduzca la opción deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("[INFO] - Has seleccionado la opción " + opcion);

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        empleados.Empleados(listaEmpleados);
                        break;
                    case 2:
                        empleados.ModificarEmpleados(listaEmpleados);
                        break;
                    case 3:
                        escritura.Escritura(listaEmpleados);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}