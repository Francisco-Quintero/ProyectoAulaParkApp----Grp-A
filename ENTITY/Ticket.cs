using System;

namespace ENTITY
{
    public class Ticket
    {
        public string Codigo { get; set; }
        public DateTime HoraEmitido { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
        public string Descripcion { get; set; }

        public Ticket(string codigo, DateTime horaEmitido, bool estado, string descripcion)
        {
            Codigo = codigo;
            HoraEmitido = horaEmitido;
            Estado = estado;
            Descripcion = descripcion;
        }

        public Ticket()
        {

        }
    }
}
