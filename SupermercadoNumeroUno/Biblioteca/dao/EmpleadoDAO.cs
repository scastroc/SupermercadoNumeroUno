using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dao
{
    public interface EmpleadoDAO
    {
        void create(EmpleadoEntity empleado);

        void update(EmpleadoEntity empleado);

        void delete(EmpleadoEntity empleado);

        List<EmpleadoEntity> findAll();
    }
}
