using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using System.Data.SqlClient;

namespace ParkApp
{
    public partial class TipoVehiculo1 : Form
    {

        private ServicioTipoVehiculo servicioTipoVehiculo;

        public TipoVehiculo1()
        {
            InitializeComponent();
            Mostrar();
            servicioTipoVehiculo = new ServicioTipoVehiculo();

        }

        string conexion = "Data Source=LAPTOP-CHO7PHK5\\SQLEXPRESS;Initial Catalog=ParckAppDB;Integrated Security=True;Encrypt=False";

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo();
        }

        private void btnMostrarGestions_Click(object sender, EventArgs e)
        {

            Mostrar();
        }


        public void RegistrarVehiculo() 
        {
            string descripcion = txtTipoVehiculo.Text;

            // Crear una nueva instancia de ENTITY.TipoVehiculo usando fully qualified name
            TipoVehiculo tipoVehiculo = new TipoVehiculo(descripcion);

            // Llamar al servicio para registrar el nuevo TipoVehiculo
            bool resultado = servicioTipoVehiculo.Crear(tipoVehiculo);

            // Mostrar mensaje de éxito o error
            if (resultado)
            {
                MessageBox.Show("Registro exitoso.");
            }
            else
            {
                MessageBox.Show("Error al registrar el Tipo de Vehículo.");
            }

        }

        public void Mostrar() 
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from TipoVehiculos ", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    cn.Open();
                    da.Fill(dt);
                }

                dataGridGestionVehiculos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }
        }


        public void ModificarVehiculo() 
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE TipoVehiculos SET Descripcion = @Descripcion WHERE IdTipoVehiculo = @IdTipoVehiculo", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Descripcion", txtTipoVehiculo.Text);
                    cmd.Parameters.AddWithValue("@IdTipoVehiculo", int.Parse(txtModificar.Text));

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos: " + ex.Message);
            }

        }

        public void EliminarVehiculo()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM TipoVehiculos WHERE IdTipoVehiculo = @IdTipoVehiculo", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdTipoVehiculo", int.Parse(txtModificar.Text));


                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos: " + ex.Message);
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarVehiculo();
        }

        private void TipoVehiculo1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
        }

    }
}
