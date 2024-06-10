using ENTITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Repositorios
{
    public class RepositorioTipoVehiculo : Conexion, IRepositorio<TipoVehiculo> 
    {
        public RepositorioTipoVehiculo(string StringConection) : base(StringConection)
        {
        }
        public RepositorioTipoVehiculo():base()
        {
                
        }

        public bool Actualizar(TipoVehiculo entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE TipoVehiculos SET Descripcion = @Descripcion WHERE IdTipoVehiculo = @IdTipoVehiculo";
                Command.Parameters.Add("@Descripcion", SqlDbType.NChar, 20).Value = entidad.Descripcion;
                Command.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = entidad.IdTipoVehiculo;

                try
                {
                    ConnectDB.Open();
                    int filasAfectadas = Command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones, log o cualquier otra acción requerida
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
        }

        public bool Crear(TipoVehiculo entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
                    {
                        Command.CommandText = "INSERT INTO TipoVehiculos (Descripcion) VALUES (@Descripcion)";
                        Command.Parameters.Add("@Descripcion", SqlDbType.NChar, 20).Value = entidad.Descripcion;

                        try
                        {
                            ConnectDB.Open();
                            Command.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException ex)
                        {
                            // Manejo de excepciones, log o cualquier otra acción requerida
                            //Console.WriteLine(ex.Message);
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
                Command.CommandText = "DELETE FROM TipoVehiculos WHERE IdTipoVehiculo = @IdTipoVehiculo";
                Command.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = id;

                try
                {
                    ConnectDB.Open();
                    int filasAfectadas = Command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones, log o cualquier otra acción requerida
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
        }

        public List<TipoVehiculo> Listar()
        {
            var listaTipoVehiculos = new List<TipoVehiculo>();

            
                using (var Command = ConnectDB.CreateCommand())
                {
                    Command.CommandText = "SELECT IdTipoVehiculo, Descripcion FROM TipoVehiculos";

                    try
                    {
                        ConnectDB.Open();
                        using (var reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                

                                listaTipoVehiculos.Add(Map(reader));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejo de excepciones, log o cualquier otra acción requerida
                        //Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ConnectDB.Close();
                    }
                }
            

            return listaTipoVehiculos;
        }

        private TipoVehiculo Map(SqlDataReader reader)
        {
            var tipoVehiculo = new TipoVehiculo(reader.GetInt32(0), reader.GetString(1).Trim());
            //{
            //    IdTipoVehiculo = reader.GetInt32(0),
            //    Descripcion = reader.GetString(1).Trim()
            //};
            return tipoVehiculo;    
        }
    }
}
