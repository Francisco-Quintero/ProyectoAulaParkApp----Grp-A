using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Vehiculo
    {
        private string placa { get; set; }
        private string tipoVehiculo { get; set; }

        public Vehiculo(string placa, string tipoVehiculo)
        {
            this.placa = placa;
            this.tipoVehiculo = tipoVehiculo;
        }
    }
}
