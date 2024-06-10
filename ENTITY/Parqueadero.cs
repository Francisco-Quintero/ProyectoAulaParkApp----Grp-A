using System;

namespace ENTITY
{
    public abstract class Parqueadero
    {
        public string Codigo { get; set; }
        public DateTime HoraEntrada { get; set; } = DateTime.Now;
        public DateTime HoraSalida { get; set; }
        public abstract double TarifaMinuto { get; }
        public TipoParqueadero TipoParqueadero { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }

        public abstract double CalcularTarifa();
    }
}
