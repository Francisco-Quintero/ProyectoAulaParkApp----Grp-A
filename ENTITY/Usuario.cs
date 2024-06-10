using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
        public int IdRol { get; set; }
    }
}
