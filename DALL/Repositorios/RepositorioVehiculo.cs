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

        private bool ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                ConnectDB.Open();
                return command.ExecuteNonQuery() > 0;
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
                Command.CommandText = "INSERT INTO Vehiculos (Placa, IdTipoVehiculo) VALUES (@Placa, @IdTipoVehiculo)";
                Command.Parameters.Add("@Placa", SqlDbType.NVarChar, 50).Value = entidad.Placa;
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





        public List<Vehiculo> FiltrarVehiculos(string textoBusqueda)
        {
            var listaVehiculos = new List<Vehiculo>();

            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdVehiculo, Placa, IdTipoVehiculo, Tarifa " +
                                      "FROM Vehiculos " +
                                      "WHERE Placa LIKE @TextoBusqueda " +
                                      "OR CAST(IdVehiculo AS NVARCHAR) LIKE @TextoBusqueda " +
                                      "OR CAST(IdTipoVehiculo AS NVARCHAR) LIKE @TextoBusqueda " +
                                      "OR CAST(Tarifa AS NVARCHAR) LIKE @TextoBusqueda";

                Command.Parameters.Add("@TextoBusqueda", SqlDbType.NVarChar).Value = "%" + textoBusqueda + "%";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var vehiculo = new Vehiculo
                            {
                                IdVehiculo = reader.GetInt32(reader.GetOrdinal("IdVehiculo")),
                                Placa = reader.GetString(reader.GetOrdinal("Placa")),
                                IdTipoVehiculo = reader.GetInt32(reader.GetOrdinal("IdTipoVehiculo")),
                                Tarifa = reader.GetDecimal(reader.GetOrdinal("Tarifa"))
                            };
                            listaVehiculos.Add(vehiculo);
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
            return listaVehiculos;
        }

        public bool EliminarPorPlaca(string placa)
        {
            using (var command = ConnectDB.CreateCommand())
            {
                command.CommandText = "DELETE FROM Vehiculos WHERE Placa = @Placa";
                command.Parameters.Add("@Placa", SqlDbType.NVarChar, 50).Value = placa;

                return ExecuteNonQuery(command);
            }
        }

        public List<Vehiculo> FiltrarVehiculo(string textoBusqueda)
        {
            throw new NotImplementedException();
        }
    }

}
