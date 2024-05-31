using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class HoraCompleta : Tarifa
    {
        private const double valorTarifa = 2000;
        public HoraCompleta() { }

        public HoraCompleta(int id, double tiempoDeParqueo, double tipoDeTarifa) : base(id, tiempoDeParqueo, tipoDeTarifa)
        {
        }

        //public double calcularTarifa(double valorTarifa, double tiempoDeParqueo)
        //{
        //    return valorTarifa * tiempoDeParqueo;
        //}
    }
}
