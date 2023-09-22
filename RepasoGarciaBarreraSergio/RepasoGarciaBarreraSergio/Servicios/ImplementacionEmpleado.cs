using RepasoGarciaBarreraSergio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGarciaBarreraSergio.Servicios
{
    class ImplementacionEmpleado : InterfazEmpleado { 
        public List<Empleado> Empleados(List<Empleado> listaEmpleados)
    {
        // Asignación aleatoria de NºSeguridadSocial
        int[] nEmpleado = { 198525, 212314, 314246, 465869, 515125, 625733, 731254, 853536, 967564, 101111, 116478, 127588, 139994, 144242, 151114, 167575, 171115, 185366, 195223, 204678 };
        Random random = new Random();
        int nSeguridadSocial = nEmpleado[random.Next(nEmpleado.Length)];

        // Implementación de la entidad y variables
        Empleado empleado = new Empleado();
        Console.WriteLine("Bienvenido, introduzca su nombre");
        empleado.Nombre = Console.ReadLine();
        Console.WriteLine("Introduzca su apellido");
        empleado.Apellido = Console.ReadLine();
        Console.WriteLine("Introduzca su DNI");
        empleado.Dni = Console.ReadLine();
        Console.WriteLine("Introduzca su fecha de nacimiento");
        empleado.FechaN = Console.ReadLine();
        Console.WriteLine("Introduzca su titulación más alta");
        empleado.TitulacionAlta = Console.ReadLine();
        // Configurar nEmpleado aleatorio
        empleado.NseguridadS = nSeguridadSocial;
        // ---
        Console.WriteLine("Introduzca su numero de cuenta");
        empleado.Ncuenta = Console.ReadLine();

        listaEmpleados.Add(empleado);
        Console.WriteLine(empleado.ToString());
        return listaEmpleados;
    }

    public List<Empleado> ModificarEmpleados(List<Empleado> listaEmpleados)
    {
        bool log = false;
        int inicio;
        // Se define un nuevo empleado pero con todos los campos vacíos,
        // este pasará a tomar todos los valores del que queremos editar
        Empleado empleadoEncontrado = null;

        Console.WriteLine("Bienvenido a modificación");
        Console.WriteLine("Entre con su numero de empleado");
        inicio = Convert.ToInt32(Console.ReadLine());
        foreach (Empleado empleado1 in listaEmpleados)
        {
            if (empleado1.NseguridadS == inicio)
            {
                // El empleado vacío pasa a tomar todos los datos del que queríamos
                empleadoEncontrado = empleado1;
                log = true;
                break;
            }
        }
        if (log)
        {
            bool seguir = true;

            do
            {
                Console.WriteLine("Qué desea cambiar?");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Apellido");
                Console.WriteLine("3. DNI");
                Console.WriteLine("4. Fecha Nacimiento");
                Console.WriteLine("5. Titulación Alta");
                Console.WriteLine("6. Numero de cuenta");
                Console.WriteLine("7. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nuevo nombre");
                        empleadoEncontrado.Nombre = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Nuevo apellido");
                        empleadoEncontrado.Apellido = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Nuevo DNI");
                        empleadoEncontrado.Dni = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Nueva fecha de nacimiento");
                        empleadoEncontrado.FechaN = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Nueva titulación más alta");
                        empleadoEncontrado.TitulacionAlta = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Nuevo numero de cuenta");
                        empleadoEncontrado.Ncuenta = Console.ReadLine();
                        break;
                    case 7:
                        seguir = false;
                        break;
                    default:
                        Console.Error.WriteLine("Opción no válida");
                        break;
                }
            } while (seguir);

            Console.WriteLine(empleadoEncontrado.ToString());
            listaEmpleados.Add(empleadoEncontrado);
        }
        else
        {
            Console.Error.WriteLine("Número incorrecto, saliendo.");
        }

        return listaEmpleados;
    }
}
