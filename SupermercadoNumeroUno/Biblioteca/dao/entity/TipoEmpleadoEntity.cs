﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.libreria
{
    public class TipoEmpleadoEntity
    {
        private int codigo;
        private string nombre;

        public TipoEmpleadoEntity()
        {

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
