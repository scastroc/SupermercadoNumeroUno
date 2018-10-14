using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface DireccionBusiness
    {
        void create(DireccionEntity direccion);

        void update(DireccionEntity direccio);

        void delete(DireccionEntity direccio);

       
    }
}
