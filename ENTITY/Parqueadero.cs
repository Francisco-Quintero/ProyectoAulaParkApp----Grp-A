using System;

namespace ENTITY
{
    public class Parqueadero
    {
        public int IdParqueadero { get; set; }
        public decimal Tarifa { get; set; }
        public DateTime HoraEntrada { get; set; } = DateTime.Now;
        public DateTime? HoraSalida { get; set; } // Permitir NULL
        public int IdVehiculo { get; set; }
        public int TipoParqueadero { get; set; }
    }
}
