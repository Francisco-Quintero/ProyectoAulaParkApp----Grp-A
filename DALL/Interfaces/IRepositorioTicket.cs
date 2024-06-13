using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Interfaces
{
    internal interface IRepositorioTicket<T>
    {
        bool Crear(T entidad);
        List<T> Listar();
    }
}
