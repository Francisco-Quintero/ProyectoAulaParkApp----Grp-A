using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioUsuario : ICrud<Usuario>
    {
        private RepositorioUsuario RepositorioUsuario = new RepositorioUsuario();

        public bool Actualizar(Usuario entidad)
        {
            return RepositorioUsuario.Actualizar(entidad);
        }

        public bool Crear(Usuario entidad)
        {
            return RepositorioUsuario.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioUsuario.Eliminar(id);
        }

        public List<Usuario> Listar()
        {
            return RepositorioUsuario.Listar();
        }
    }
}
