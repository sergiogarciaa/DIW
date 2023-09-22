using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGarciaBarreraSergio.Entidades
{
    internal class Empleado
    {
        public Empleado(string nombre, string apellido, string dni, string fechaN, string titulacionAlta, int nseguridadS, string ncuenta)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.FechaN = fechaN;
            this.TitulacionAlta = titulacionAlta;
            this.NseguridadS = nseguridadS;
            this.Ncuenta = ncuenta;
        }

        public Empleado()
        {
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string FechaN { get; set; }
        public string TitulacionAlta { get; set; }
        public int NseguridadS { get; set; }
        public string Ncuenta { get; set; }

        // Sobreescritura ToString
        public override string ToString()
        {
            return "Nombre: " + Nombre + " | Apellido: " + Apellido + " | DNI: " + Dni + " | Fecha Nacimiento: " + FechaN + " | Titulación más Alta " + TitulacionAlta + " | Numero SC " + NseguridadS + " | Numero de cuenta " + Ncuenta;
        }
    }
}
