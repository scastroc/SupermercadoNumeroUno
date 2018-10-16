using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dao
{
    public interface TipoEmpleadoDAO
    {
        void create(TipoEmpleadoEntity tipoEmpleado);

        void update(TipoEmpleadoEntity tipoEmpleado);

        void delete(TipoEmpleadoEntity tipoEmpleado);

        List<TipoEmpleadoEntity> findAll();
    }
}
