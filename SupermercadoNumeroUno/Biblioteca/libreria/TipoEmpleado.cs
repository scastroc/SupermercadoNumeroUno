using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.libreria
{
    public class TipoEmpleado
    {
        private string codigo;
        private string nombre;

        public TipoEmpleado()
        {

        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
