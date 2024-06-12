using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Repositorios
{
    public class RepositorioTipoParqueadero : Conexion, IRepositorio<TipoParqueadero>
    {
        public RepositorioTipoParqueadero(string StringConection) : base(StringConection)
        {
        }

        public RepositorioTipoParqueadero() : base()
        {

        }

        public bool Actualizar(TipoParqueadero entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE TipoParqueadero SET Descripcion = @Descripcion WHERE IdTipoParqueadero = @IdTipoParqueadero";
                Command.Parameters.Add("@Descripcion", SqlDbType.NChar, 20).Value = entidad.Descripcion;
                Command.Parameters.Add("@IdTipoParqueadero", SqlDbType.Int).Value = entidad.TipoParqueaderos;

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

        public bool Crear(TipoParqueadero entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO TipoParqueadero (Descripcion) VALUES (@Descripcion)";
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
                Command.CommandText = "DELETE FROM TipoParqueadero WHERE IdTipoParqueadero = @IdTipoParqueadero";
                Command.Parameters.Add("@IdTipoParqueadero", SqlDbType.Int).Value = id;

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

        public List<TipoParqueadero> Listar()
        {
            var ListaTipoParqueadero = new List<TipoParqueadero>();


            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdTipoParqueadero, Descripcion FROM TipoParqueadero";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            ListaTipoParqueadero.Add(Map(reader));
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
            return ListaTipoParqueadero;
        }

        private TipoParqueadero Map(SqlDataReader reader)
        {
            var tipoParqueadero = new TipoParqueadero(reader.GetString(0).Trim(), reader.GetString(1).Trim());
            return tipoParqueadero;
        }

        public List<TipoParqueadero> FiltrarVehiculo(string textoBusqueda)
        {
            throw new NotImplementedException();
        }
    }
}