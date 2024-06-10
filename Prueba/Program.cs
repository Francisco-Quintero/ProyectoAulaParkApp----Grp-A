using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DALL.Repositorios.RepositorioTipoVehiculo repositorioTipoVehiculo= new DALL.Repositorios.RepositorioTipoVehiculo();
            //ENTITY.TipoVehiculo tipoVehiculo1 = new ENTITY.TipoVehiculo("Moto");
            //ENTITY.TipoVehiculo tipoVehiculo2 = new ENTITY.TipoVehiculo("Bicicleta");

            DALL.Repositorios.RepositorioTipoParqueadero repositorioTipoParqueadero = new DALL.Repositorios.RepositorioTipoParqueadero();
            ENTITY.TipoParqueadero tipoParqueadero1 = new ENTITY.TipoParqueadero("Parqueadero Carro");
            ENTITY.TipoParqueadero tipoParqueadero2 = new ENTITY.TipoParqueadero("Parqueadero Moto");


            //CREAR UN TIPO DE PARQUEADERO
            repositorioTipoParqueadero.Crear(tipoParqueadero1);




            //CREAR UN TIPO DE VEHICULO
            //repositorioTipoVehiculo.Crear(tipoVehiculo2); 


            //,
            //Listar Los Tipos de Vehiculo
            //var lista = repositorioTipoVehiculo.Listar(); 
            //foreach (var item in lista)
            //{
            //    Console.WriteLine( item.Descripcion);
            //}
            //Console.ReadKey();

            //Eliminar el tipo de vehiculo
            //repositorioTipoVehiculo.Eliminar(2);
        }
    }
}
