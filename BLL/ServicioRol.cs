using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioRol : ICrud<Rol>
    {
        private RepositorioRol RepositorioRol = new RepositorioRol();

        public bool Actualizar(Rol entidad)
        {
            return RepositorioRol.Actualizar(entidad);
        }

        public bool Crear(Rol entidad)
        {
            return RepositorioRol.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioRol.Eliminar(id);
        }

        public List<Rol> Listar()
        {
            return RepositorioRol.Listar();
        }
    }
}
