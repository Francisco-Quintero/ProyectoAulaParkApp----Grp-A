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
    public class RepositorioRol : Conexion, IRepositorio<Rol>
    {
        public RepositorioRol(string StringConection) : base(StringConection)
        {
        }

        public RepositorioRol() : base()
        {

        }

        public bool Actualizar(Rol entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE Roles SET Nombre = @Nombre, Estado = @Estado WHERE IdRol = @IdRol";
                Command.Parameters.Add("@IdRol", SqlDbType.NChar, 20).Value = entidad.IdRol;
                Command.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = entidad.Nombre;
                Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;

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

        public bool Crear(Rol entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Roles (IdRol, Nombre, Estado) VALUES (@IdRol, @Nombre, @Estado)";
                Command.Parameters.Add("@IdRol", SqlDbType.NChar, 20).Value = entidad.IdRol;
                Command.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = entidad.Nombre;
                Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;

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
                Command.CommandText = "DELETE FROM Roles WHERE IdRol = @IdRol";
                Command.Parameters.Add("@IdRol", SqlDbType.NChar, 20).Value = id;

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

        public List<Rol> Listar()
        {
            var ListaRol = new List<Rol>();


            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdRol, Nombre, Estado FROM Roles";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaRol.Add(Map(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Manejo de excepciones, log o cualquier otra acción requerida
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ConnectDB.Close();
                }
            }
            return ListaRol;
        }

        private Rol Map(SqlDataReader reader)
        {
            var rol = new Rol(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetBoolean(2));
            return rol;
        }
    }
}
