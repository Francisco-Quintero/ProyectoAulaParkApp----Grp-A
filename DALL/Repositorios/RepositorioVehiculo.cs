using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Repositorios
{
    public class RepositorioVehiculo : Conexion, IRepositorio<Vehiculo>
    {
        public RepositorioVehiculo(string StringConection) : base(StringConection)
        {
        }

        public RepositorioVehiculo() : base()
        {
        }

        public bool Actualizar(Vehiculo entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE Vehiculo SET Placa = @Placa, IdTipoVehiculo = @IdTipoVehiculo WHERE IdVehiculo = @IdVehiculo";
                Command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = entidad.IdVehiculo;
                Command.Parameters.Add("@Placa", SqlDbType.NChar, 7).Value = entidad.Placa;
                Command.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = entidad.IdTipoVehiculo;
              

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

        public bool Crear(Vehiculo entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Vehiculo (Placa, IdTipoVehiculo) VALUES (@Placa, @IdTipoVehiculo)";
                Command.Parameters.Add("@Placa", SqlDbType.NChar, 7).Value = entidad.Placa;
                Command.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = entidad.IdTipoVehiculo;


                try
                {
                    ConnectDB.Open();
                    Command.ExecuteNonQuery();
                    return true;
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
                Command.CommandText = "DELETE FROM Vehiculo WHERE IdVehiculo = @IdVehiculo";
                Command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = id;

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

        public List<Vehiculo> Listar()
        {
            var listaVehiculos = new List<Vehiculo>();

            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdVehiculo, Placa, IdTipoVehiculo FROM Vehiculos";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var vehiculo = new Vehiculo
                            {
                                IdVehiculo = reader.GetInt32(0),
                                Placa = reader.GetString(1).Trim(),
                                IdTipoVehiculo = reader.GetInt32(2),
                                
                            };
                            listaVehiculos.Add(vehiculo);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
            return listaVehiculos;
        }
    }
}
