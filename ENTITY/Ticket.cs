using System;

namespace ENTITY
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public DateTime HoraEmititido { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public int IdPersona { get; set; }

        public Ticket(int idTicket, DateTime horaEmititido, bool estado, string descripcion, int idPersona)
        {
            IdTicket = idTicket;
            HoraEmititido = horaEmititido;
            Estado = estado;
            Descripcion = descripcion;
            IdPersona = idPersona;
        }

        public Ticket()
        {
        }
    }
}
