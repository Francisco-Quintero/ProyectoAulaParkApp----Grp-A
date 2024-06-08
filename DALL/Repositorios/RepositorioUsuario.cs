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
    public class RepositorioUsuario : Conexion, IRepositorio<Usuario>
    {
        public RepositorioUsuario(string StringConection) : base(StringConection)
        {
        }

        public bool Actualizar(Usuario entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "UPDATE Usuarios" +
                " SET  Persona = @Persona, Rol = @Rol, Nombre = @Nombre, Contraseña = @Contraseña, Estado= @Estado, FechaCreacion= @FechaCreacion  WHERE Id = @Id";
                Command.Parameters.Add("Persona", SqlDbType.NChar).Value = entidad.Persona;
                Command.Parameters.Add("Rol", SqlDbType.NChar).Value = entidad.Rol;
                Command.Parameters.Add("Nombre", SqlDbType.NChar).Value = entidad.Nombre;
                Command.Parameters.Add("Contraseña", SqlDbType.NChar).Value = entidad.Contraseña;
                Command.Parameters.Add("Estado", SqlDbType.Bit).Value = entidad.Estado;
                Command.Parameters.Add("FechaCreacion", SqlDbType.DateTime).Value = entidad.FechaCreacion;

                ConnectDB.Open();

                Command.ExecuteNonQuery();
                ConnectDB.Close();
            }

            return false;
        }

        public bool Crear(Usuario entidad)
        {
            
               
                    using (var Command = ConnectDB.CreateCommand())
                    {
                        Command.CommandText = "INSERT INTO Usuarios (Persona, Rol, Nombre, Contraseña, Estado, FechaCreacion) " +
                                              "VALUES (@Persona, @Rol, @Nombre, @Contraseña, @Estado, @FechaCreacion)";
                        Command.Parameters.Add("@Persona", SqlDbType.NChar).Value = entidad.Persona;
                        Command.Parameters.Add("@Rol", SqlDbType.NChar).Value = entidad.Rol;
                        Command.Parameters.Add("@Nombre", SqlDbType.NChar).Value = entidad.Nombre;
                        Command.Parameters.Add("@Contraseña", SqlDbType.NChar).Value = entidad.Contraseña;
                        Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;
                        Command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = entidad.FechaCreacion;

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
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
