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
            TimeSpan duracion = (TimeSpan)(Parqueadero.HoraSalida - Parqueadero.HoraEntrada);
            decimal horas = (decimal)duracion.TotalHours;

            return (double)(horas * Parqueadero.Tarifa);

        }
    }
}
