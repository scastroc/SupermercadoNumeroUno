using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface ComunaBusiness
    {
        void create(ComunaEntity comuna);

        void update(ComunaEntity comuna);

        void delete(ComunaEntity comuna);

        List<ComunaEntity> listComuna();
    }
}
