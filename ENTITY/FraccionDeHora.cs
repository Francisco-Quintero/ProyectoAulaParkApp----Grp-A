using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class FraccionDeHora : Tarifa
    {
        private const double valorTarifa = 1000;

        public FraccionDeHora()
        {
        }

        public FraccionDeHora(int id, double tiempoDeParqueo, double tipoDeTarifa) : base(id, tiempoDeParqueo, tipoDeTarifa)
        {
        }

        //public double calcularTarifa (double valorTarifa, double tiempoDeParqueo)
        //{
        //    return valorTarifa * tiempoDeParqueo;
        //}
    }
}
