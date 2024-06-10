using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ParqueaderoCarro : Parqueadero
    {
        public override double TarifaMinuto => 2000;

        public override double CalcularTarifa()
        {
            return HoraSalida.Subtract(HoraEntrada).TotalMinutes * TarifaMinuto;
        }
    }
}
