using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioTipoVehiculo
    {
        private RepositorioTipoVehiculo RepositorioTipoVehiculo = new RepositorioTipoVehiculo();

        public bool Actualizar(TipoVehiculo entidad)
        {
            return RepositorioTipoVehiculo.Actualizar(entidad);
        }

        public bool Crear(TipoVehiculo entidad)
        {
            return RepositorioTipoVehiculo.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioTipoVehiculo.Eliminar(id);
        }

        public List<TipoVehiculo> Listar()
        {
            return RepositorioTipoVehiculo.Listar();
        }
    }
}
