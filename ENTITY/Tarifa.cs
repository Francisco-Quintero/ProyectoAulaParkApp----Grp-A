using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Tarifa
    {
        private int id {  get; set; }
        private double tiempoDeParqueo { get; set; }
        private double tipoDeTarifa { get; set; }

        public Tarifa()
        {
        }

        public Tarifa(int id, double tiempoDeParqueo, double tipoDeTarifa)
        {
            this.id = id;
            this.tiempoDeParqueo = tiempoDeParqueo;
            this.tipoDeTarifa = tipoDeTarifa;
        }

        public double calcularTarifa (double tiempoDeParqueo, double valorTarifa)
        {
            return tiempoDeParqueo * valorTarifa;
        }
    }
}
