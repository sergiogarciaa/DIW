using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGarciaBarreraSergio.Servicios
{
    internal class ImplementacionMenu : InterfazMenu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("1. Cerrar APP");
            Console.WriteLine("2. Crear Empleado");
            Console.WriteLine("3. Modificación empleado");
            Console.WriteLine("4. Exportar a fichero");
        }
    }
}
