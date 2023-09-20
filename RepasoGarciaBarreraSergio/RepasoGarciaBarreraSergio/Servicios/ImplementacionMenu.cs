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
            Console.WriteLine("1. Registro empleado");
            Console.WriteLine("2. Modificación empleado");
            Console.WriteLine("3. Exportar a fichero");
            Console.WriteLine("4. Cerrar app");
        }
    }
}
