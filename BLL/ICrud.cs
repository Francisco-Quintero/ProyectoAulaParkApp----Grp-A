using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface ICrud<T>
    {
        bool Crear(T entidad);

        bool Actualizar(T entidad);

        bool Eliminar(int id);

        List<T> Listar();
    }
}
