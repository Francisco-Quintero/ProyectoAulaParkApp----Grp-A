using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Vehiculo
    {



        public Vehiculo(string placa)
        { 
          
            string Placa = placa;
      
        
        }

        public Vehiculo(int idVehiculo, string placa, int idTipoVehiculo)
        {
            IdVehiculo = idVehiculo;
            Placa = placa;
            IdTipoVehiculo = idTipoVehiculo;
            
        }

        public Vehiculo()
        {
            
        }


        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public int IdTipoVehiculo { get; set; }
        
    }
}
