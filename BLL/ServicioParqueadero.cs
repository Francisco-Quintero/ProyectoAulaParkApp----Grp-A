using DALL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ServicioParqueadero : ICrud<Parqueadero>
    {
        private RepositorioParqueadero RepositorioParqueadero = new RepositorioParqueadero();
        private Parqueadero Parqueadero = new Parqueadero();

        public bool Actualizar(Parqueadero entidad)
        {
            return RepositorioParqueadero.Actualizar(entidad);
        }

        //public override double TarifaMinuto => 2000;

        public bool Crear(Parqueadero entidad)
        {
            return RepositorioParqueadero.Crear(entidad);
        }

        public bool Eliminar(int id)
        {
            return RepositorioParqueadero.Eliminar(id);
        }

        public List<Parqueadero> Listar()
        {
            return RepositorioParqueadero.Listar();
        }

        public double CalcularTarifa()
        {
            TimeSpan duracion = Parqueadero.HoraSalida - Parqueadero.HoraEntrada;
            double horas = (double)duracion.TotalHours;

            return horas * Parqueadero.TarifaMinuto;

        }
    }
}
