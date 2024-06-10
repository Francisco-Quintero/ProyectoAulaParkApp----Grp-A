using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioTicket
    {
        private readonly RepositorioTicket _ticketRepository;

        public ServicioTicket()
        {
            _ticketRepository = new RepositorioTicket();
        }

        public bool GenerarTicket(int idPersona, string descripcion)
        {
            // Crear el ticket
            var ticket = new Ticket
            {
                HoraEmititido = DateTime.Now,
                Estado = true,
                Descripcion = descripcion,
                IdPersona = idPersona
            };

            // Guardar el ticket en la base de datos
            return _ticketRepository.Crear(ticket);
        }

        public bool Crear(Ticket entidad)
        {
            return _ticketRepository.Crear(entidad);
        }
    }
}
