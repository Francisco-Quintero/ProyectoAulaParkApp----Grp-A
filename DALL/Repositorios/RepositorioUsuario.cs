using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Repositorios
{
    public class RepositorioUsuario : Conexion, IRepositorio<Usuario>
    {
        public RepositorioUsuario(string StringConection) : base(StringConection)
        {
        }

        public RepositorioUsuario()
        {
            
        }

        public bool Actualizar(Usuario entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE Usuarios SET Nombre = @Nombre, Contraseña = @Contraseña, FechaCreacion = @FechaCreacion, " +
                                      "Estado = @Estado, IdRol = @IdRol WHERE IdUsuario = @IdUsuario";
                Command.Parameters.Add("@Nombre", SqlDbType.NChar).Value = entidad.Nombre;
                Command.Parameters.Add("@Contraseña", SqlDbType.NChar).Value = entidad.Contraseña;
                Command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = entidad.FechaCreacion;
                Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;
                Command.Parameters.Add("@IdRol", SqlDbType.Int).Value = entidad.IdRol;
                Command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = entidad.IdUsuario;

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

        public bool Crear(Usuario entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Usuarios (Nombre, Contraseña, FechaCreacion, Estado, IdRol) " +
                                      "VALUES (@Nombre, @Contraseña, @FechaCreacion, @Estado, @IdRol)";
                Command.Parameters.Add("@Nombre", SqlDbType.NChar).Value = entidad.Nombre;
                Command.Parameters.Add("@Contraseña", SqlDbType.NChar).Value = entidad.Contraseña;
                Command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = entidad.FechaCreacion;
                Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;
                Command.Parameters.Add("@IdRol", SqlDbType.Int).Value = entidad.IdRol;

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
                Command.CommandText = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                Command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = id;

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

        public List<Usuario> Listar()
        {
            var listaUsuarios = new List<Usuario>();

            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "SELECT IdUsuario, Nombre, Contraseña, FechaCreacion, Estado, IdRol FROM Usuarios";

                try
                {
                    ConnectDB.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new Usuario
                            {
                                IdUsuario = reader.GetInt32(0),
                                Nombre = reader.GetString(1).Trim(),
                                Contraseña = reader.GetString(2).Trim(),
                                FechaCreacion = reader.GetDateTime(3),
                                Estado = reader.GetBoolean(4),
                                IdRol = reader.GetInt32(5)
                            };
                            listaUsuarios.Add(usuario);
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
            return listaUsuarios;
        }
    }
}
