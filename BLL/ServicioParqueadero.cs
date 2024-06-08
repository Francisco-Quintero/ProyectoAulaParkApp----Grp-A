using ENTITY;
using System.Collections.Generic;

namespace BLL
{
    public class ServicioParqueadero : Parqueadero, ICrud<Parqueadero>
    {
        public bool Actualizar(Parqueadero entidad)
        {
            throw new System.NotImplementedException();
        }

        //public override double TarifaMinuto => 2000;

        public override double CalcularTarifa()
        {
            return HoraSalida.Subtract(HoraEntrada).TotalMinutes * TarifaMinuto;
        }

        public bool Crear(Parqueadero entidad)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public override Ticket GenerarLiquidacion()
        {
            double tarifa = CalcularTarifa();
            Ticket ticket = new Ticket();
            GenerarTicket(ticket, tarifa);
            return ticket;
        }

        public void GenerarTicket(Ticket ticket, double tarifa)
        {
            new Ticket();

        }

        public List<Parqueadero> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
