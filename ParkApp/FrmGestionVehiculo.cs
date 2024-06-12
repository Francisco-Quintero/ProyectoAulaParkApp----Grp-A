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
            
            servicioTipoVehiculo = new ServicioTipoVehiculo();

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo();
            Mostrar();
        }

        private void btnMostrarGestions_Click(object sender, EventArgs e)
        {
            Mostrar();

        }

     
        public void Mostrar() 
        {
            
            List<TipoVehiculo> tiposVehiculo = servicioTipoVehiculo.Listar();

            
            dataGridGestionVehiculos.DataSource = tiposVehiculo;

        }

        private void ModificarTipoVehiculo(int idTipoVehiculo)
        {
           
            TipoVehiculo tipoVehiculo = servicioTipoVehiculo.Listar().FirstOrDefault(tv => tv.IdTipoVehiculo == idTipoVehiculo);

           
            if (tipoVehiculo != null)
            {
               
                tipoVehiculo.Descripcion = txtTipoVehiculo.Text; 

        
                bool resultado = servicioTipoVehiculo.Actualizar(tipoVehiculo);

            
                if (resultado)
                {
                    MessageBox.Show("Registro actualizado correctamente.");

                   
                    btnMostrarGestions_Click(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
            }
        }


        private void EliminarTipoVehiculo(int idTipoVehiculo)
        {
          
            bool resultado = servicioTipoVehiculo.Eliminar(idTipoVehiculo);

         
            if (resultado)
            {
                MessageBox.Show("Registro eliminado correctamente.");

                
                btnMostrarGestions_Click(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro.");
            }
        }

        public void RegistrarVehiculo() 
        {
            string descripcion = txtTipoVehiculo.Text;

            
            TipoVehiculo tipoVehiculo = new TipoVehiculo(descripcion);

            
            bool resultado = servicioTipoVehiculo.Crear(tipoVehiculo);
         


            if (resultado)
            {
                MessageBox.Show("Registro exitoso.");
            }
            else
            {
                MessageBox.Show("Error al registrar el Tipo de Vehículo.");
            }

            txtModificar.Text = "";
            txtTipoVehiculo.Text = "";

        }

      

        

       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtModificar.Text, out int idTipoVehiculo))
            {
                ModificarTipoVehiculo(idTipoVehiculo);
                txtModificar.Text = "";
                txtTipoVehiculo.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void TipoVehiculo1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtModificar.Text, out int idTipoVehiculo))
            {
                EliminarTipoVehiculo(idTipoVehiculo);
                txtModificar.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

    }
}
