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
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoParqueadero> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
