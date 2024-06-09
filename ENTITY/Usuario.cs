﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public Rol Rol { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}