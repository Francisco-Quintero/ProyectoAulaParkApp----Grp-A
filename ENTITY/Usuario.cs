using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {

        public Usuario()
        {
            
        }
        public Usuario(string nombre, string contraseña)
        {

            Nombre = nombre;
            Contraseña = contraseña;
        }

        public Usuario(int idUsuario, string nombre, string contraseña, DateTime fechaCreacion, bool estado, int idRol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            IdRol = idRol;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
        public int IdRol { get; set; }
    }
}
