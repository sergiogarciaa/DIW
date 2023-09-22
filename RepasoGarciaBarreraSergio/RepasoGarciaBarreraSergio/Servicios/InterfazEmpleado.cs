using RepasoGarciaBarreraSergio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGarciaBarreraSergio.Servicios
{
    internal interface InterfazEmpleado
    {
        List<Empleado> Empleados(List<Empleado> listaEmpleados);
        List<Empleado> ModificarEmpleados(List<Empleado> listaEmpleados);
    }
}
