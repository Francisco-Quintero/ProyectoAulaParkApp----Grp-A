using System.Collections.Generic;

namespace DALL
{
    public interface IRepositorio<T> where T : class
    {
        bool Crear(T entidad);

        bool Actualizar(T entidad);

        bool Eliminar(int id);

        List<T> Listar();

        List<T> FiltrarVehiculo(string textoBusqueda);
    }
}
