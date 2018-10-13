using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.libreria
{
    public class Direccion
    {
        private string nombreCalle;
        private int numero;
        private Comuna comuna;

        public Direccion()
        {

        }

        
        public string NombreCalle
        {
            get
            {
                return nombreCalle;
            }

            set
            {
                nombreCalle = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public Comuna Comuna
        {
            get
            {
                return comuna;
            }

            set
            {
                comuna = value;
            }
        }

       


        

    }
}
