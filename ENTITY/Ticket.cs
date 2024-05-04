using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ticket
    {
        public int id { get; set; }
        public DateTime horaEmitido { get; set; }

        public Ticket(int id, DateTime horaEmitido)
        {
            this.id = id;
            this.horaEmitido = horaEmitido;
        }
    }
}
