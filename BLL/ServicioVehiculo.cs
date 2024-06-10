using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioVehiculo : ICrud<Vehiculo>
    {
        private RepositorioVehiculo RepositorioVehiculo = new RepositorioVehiculo();

        public bool Actualizar(Vehiculo entidad)
        {
            return RepositorioVehiculo.Actualizar(entidad);
        }

        public bool Crear(Vehiculo entidad)
        {
            return RepositorioVehiculo.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioVehiculo.Eliminar(id);
        }

        public List<Vehiculo> Listar()
        {
            return RepositorioVehiculo.Listar();
        }
    }
}
