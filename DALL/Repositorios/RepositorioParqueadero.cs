using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Repositorios
{
    public class RepositorioParqueadero : Conexion, IRepositorio<Parqueadero>
    {
        public RepositorioParqueadero(string StringConection) : base(StringConection)
        {
        }

        public RepositorioParqueadero() : base()
        {

        }

        public bool Actualizar(Parqueadero entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE Parqueaderos SET Tarifa = @Tarifa, HoraEntrada = @HoraEntrada, HoraSalida = @HoraSalida, IdVehiculo = @IdVehiculo, TipoParqueadero = @TipoParqueadero WHERE IdParqueadero = @IdParqueadero";
                Command.Parameters.Add("@IdParqueadero", SqlDbType.Int).Value = entidad.IdParqueadero;
                Command.Parameters.Add("@Tarifa", SqlDbType.Decimal).Value = entidad.Tarifa;
                Command.Parameters.Add("@HoraEntrada", SqlDbType.DateTime).Value = entidad.HoraEntrada;
                Command.Parameters.Add("@HoraSalida", SqlDbType.DateTime).Value = entidad.HoraSalida;
                Command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = entidad.IdVehiculo;
                Command.Parameters.Add("@TipoParqueadero", SqlDbType.Int).Value = entidad.TipoParqueadero;

                try
                {
                    ConnectDB.Open();
                    int filasAfectadas = Command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
        }

        public bool Crear(Parqueadero entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Parqueaderos (Tarifa, HoraEntrada, HoraSalida, IdVehiculo, TipoParqueadero) VALUES (@Tarifa, @HoraEntrada, @HoraSalida, @IdVehiculo, @TipoParqueadero)";
                Command.Parameters.Add("@Tarifa", SqlDbType.Decimal).Value = entidad.Tarifa;
                Command.Parameters.Add("@HoraEntrada", SqlDbType.DateTime).Value = entidad.HoraEntrada;
                Command.Parameters.Add("@HoraSalida", SqlDbType.DateTime).Value = (object)entidad.HoraSalida ?? DBNull.Value; // Permitir NULL
                Command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = entidad.IdVehiculo;
                Command.Parameters.Add("@TipoParqueadero", SqlDbType.Int).Value = entidad.TipoParqueadero;

                try
                {
                    ConnectDB.Open();
                    int filasAfectadas = Command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "DELETE FROM Parqueaderos WHERE IdParqueadero = @IdParqueadero";
                Command.Parameters.Add("@IdParqueadero", SqlDbType.Int).Value = id;

                try
                {
                    ConnectDB.Open();
                    int filasAfectadas = Command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
        }

        public List<Parqueadero> Listar()
        {
            var ListaParqueadero = new List<Parqueadero>();

            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdParqueadero, Tarifa, HoraEntrada, HoraSalida, IdVehiculo, TipoParqueadero FROM Parqueaderos";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaParqueadero.Add(MapParqueadero(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones, log o cualquier otra acción requerida
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
            return ListaParqueadero;
        }

        private Parqueadero MapParqueadero(SqlDataReader reader)
        {
            return new Parqueadero
            {
                IdParqueadero = (int)reader["IdParqueadero"],
                Tarifa = (decimal)reader["Tarifa"],
                HoraEntrada = (DateTime)reader["HoraEntrada"],
                HoraSalida = (DateTime)reader["HoraSalida"],
                IdVehiculo = (int)reader["IdVehiculo"],
                TipoParqueadero = (int)reader["TipoParqueadero"]
            };
        }
    }
}
