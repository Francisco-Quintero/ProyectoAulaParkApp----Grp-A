using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Parqueo
    {
        private int id { get; set; }
        private DateTime horaEntrada { get; set; }
        private DateTime horaSalida { get; set; }
        private Vehiculo tipoVehiculo { get; set; }

        public Parqueo(int id, DateTime horaEntrada, DateTime horaSalida, Vehiculo tipoVehiculo)
        {
            this.id = id;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.tipoVehiculo = tipoVehiculo;
        }
    }
}
