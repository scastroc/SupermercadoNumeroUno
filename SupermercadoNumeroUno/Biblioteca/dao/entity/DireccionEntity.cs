using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.libreria
{
    public class DireccionEntity
    {
        private string nombreCalle;
        private int numero;
        private ComunaEntity comuna;

        public DireccionEntity()
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

        public ComunaEntity Comuna
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
