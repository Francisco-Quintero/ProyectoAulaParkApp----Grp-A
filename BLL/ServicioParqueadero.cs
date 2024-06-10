using DALL.Repositorios;
using ENTITY;
using System.Collections.Generic;

namespace BLL
{
    public class ServicioParqueadero
    {
        private RepositorioParqueadero RepositorioParqueadero = new RepositorioParqueadero();

        public bool Actualizar(Parqueadero entidad)
        {
            return RepositorioParqueadero.Actualizar(entidad);
        }

        //public override double TarifaMinuto => 2000;

        public bool Crear(Parqueadero entidad)
        {
            return RepositorioParqueadero.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioParqueadero.Eliminar(id);
        }

        public List<Parqueadero> Listar()
        {
            return RepositorioParqueadero.Listar();
        }
    }
}
