using System;
using System.Configuration;
using System.Data.SqlClient;


namespace DALL
{
    public class Conexion
    {
        internal SqlConnection ConnectDB;

        public Conexion()
        {
            ConnectDB= new SqlConnection();
            ConnectDB.ConnectionString = "Server=.\\SQLEXPRESS;Database=ParckAppDB;Trusted_Connection=True;";
                
        }
        public Conexion (string StringConection)
        {
            ConnectDB = new SqlConnection(StringConection);
        }

        public void Open()
        {
            try
            {
                ConnectDB.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        public void Close()
        {
            ConnectDB.Close();
        }
    }
}