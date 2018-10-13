using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.libreria
{
    public class Empleado
    {
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string run;
        private TipoEmpleado tipoEmpleado;
        private Direccion direccion;
        private int telefono;
        private int remuneracion;
        private DateTime fechaNacimiento;

        public Empleado()
        {

        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
            }
        }

        public string Run
        {
            get
            {
                return run;
            }

            set
            {
                run = value;
            }
        }

        public TipoEmpleado TipoEmpleado
        {
            get
            {
                return tipoEmpleado;
            }

            set
            {
                tipoEmpleado = value;
            }
        }

        public Direccion Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int Remuneracion
        {
            get
            {
                return remuneracion;
            }

            set
            {
                remuneracion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }


    }
}
