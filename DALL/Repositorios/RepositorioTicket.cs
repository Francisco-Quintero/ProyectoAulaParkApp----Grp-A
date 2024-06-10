using DALL.Interfaces;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Repositorios
{
    public class RepositorioTicket : Conexion, IRepositorioTicket<Ticket>
    {
        public RepositorioTicket(string StringConection) : base(StringConection)
        {
        }

        public RepositorioTicket() : base()
        {

        }

        public bool Crear(Ticket entidad)
        {
            using (var Command = ConnectDB.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Tickets (HoraEmititido, Estado, Descripcion, IdPersona) " +
                                      "VALUES (@HoraEmititido, @Estado, @Descripcion, @IdPersona)";
                Command.Parameters.Add("@HoraEmititido", SqlDbType.DateTime).Value = entidad.HoraEmititido;
                Command.Parameters.Add("@Estado", SqlDbType.Bit).Value = entidad.Estado;
                Command.Parameters.Add("@Descripcion", SqlDbType.NChar).Value = entidad.Descripcion;
                Command.Parameters.Add("@IdPersona", SqlDbType.Int).Value = entidad.IdPersona;

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

        public List<Ticket> Listar()
        {
            throw new NotImplementedException();
        }

        //public List<Ticket> BuscarTickets(string terminoBusqueda)
        //{
        //    var tickets = new List<Ticket>();
        //    {
        //        using (var Command = ConnectDB.CreateCommand())
        //        {
        //            Command.CommandText = "SELECT IdTicket, HoraEmititido, Estado, Descripcion, IdPersona FROM Tickets " +
        //                                  "WHERE Descripcion LIKE @terminoBusqueda";
        //            Command.Parameters.Add("@terminoBusqueda", SqlDbType.NChar).Value = "%" + terminoBusqueda + "%";

        //            ConnectDB.Open();
        //            using (var reader = Command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var ticket = new Ticket
        //                    {
        //                        IdTicket = reader.GetInt32(0),
        //                        HoraEmititido = reader.GetDateTime(1),
        //                        Estado = reader.GetBoolean(2),
        //                        Descripcion = reader.GetString(3).Trim(),
        //                        IdPersona = reader.GetInt32(4)
        //                    };
        //                    tickets.Add(ticket);
        //                }
        //            }
        //        }
        //    }
        //    return tickets;
        //}
    }
}
