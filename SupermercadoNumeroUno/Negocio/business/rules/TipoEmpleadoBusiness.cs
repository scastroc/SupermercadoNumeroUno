using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface TipoEmpleadoBusiness
    {
        void create(TipoEmpleadoEntity tipoEmpleado);

        void update(TipoEmpleadoEntity tipoEmpleado);

        void delete(TipoEmpleadoEntity tipoEmpleado);

        List<TipoEmpleadoEntity> listTipoEmp();

    }
}
