using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ParqueaderoMoto : Parqueadero
    {
        public override double TarifaMinuto => 1000;

        public override double CalcularTarifa()
        {
            return HoraSalida.Subtract(HoraEntrada).TotalMinutes * TarifaMinuto;
        }
    }
}
