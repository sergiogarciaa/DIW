using RepasoGarciaBarreraSergio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGarciaBarreraSergio.Servicios
{
    class ImplementacionEscritura : InterfazEscritura
    {
        public void Escritura(List<Empleado> listaEmpleado)
        {
            StreamWriter fichero = null;
            bool uno = false;

            // Un usuario solamente o todos
            Empleado empleadoEncontrado = null;

            Console.WriteLine("Bienvenido a modificación");
            Console.WriteLine("Si solo desea imprimir un empleado, introduzca su Numero de Empleado. Si desea imprimir todos, simplemente pulse Intro.");
            string respuestaStr = Console.ReadLine();

            if (int.TryParse(respuestaStr, out int respuesta))
            {
                foreach (Empleado empleado1 in listaEmpleado)
                {
                    if (empleado1.NseguridadS == respuesta)
                    {
                        empleadoEncontrado = empleado1;
                        uno = true;
                        break;
                    }
                }
            }

            // Solo un usuario
            if (uno)
            {
                try
                {
                    fichero = new StreamWriter(@"C:\Users\Puesto14\Desktop\fichero.txt");
                    fichero.WriteLine(empleadoEncontrado.Nombre + empleadoEncontrado.Apellido + empleadoEncontrado.Dni + empleadoEncontrado.FechaN + empleadoEncontrado.TitulacionAlta);
                }
                catch (IOException ioe)
                {
                    Console.WriteLine("[ERROR] - FICHERO NO ENCONTRADO: " + fichero + "\n" + ioe);
                }
                finally
                {
                    fichero?.Close();
                }
            }
            // Todos los usuarios
            else
            {
                try
                {
                    fichero = new StreamWriter(@"C:\Users\Puesto14\Desktop\fichero.txt");
                    foreach (Empleado em in listaEmpleado)
                    {
                        fichero.WriteLine(em.Nombre + em.Apellido + em.Dni + em.FechaN + em.TitulacionAlta);
                    }
                }
                catch (IOException ioe)
                {
                    Console.WriteLine("[ERROR] - FICHERO NO ENCONTRADO: " + fichero + "\n" + ioe);
                }
                finally
                {
                    fichero?.Close();
                }
            }
        }
    }
}
