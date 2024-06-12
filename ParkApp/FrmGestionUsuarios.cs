using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ParkApp
{
    public partial class FrmGestionUsuarios : Form
    {

        private ServicioUsuario servicioUsuario;
        private ServicioRol servicioRol;
        
        public FrmGestionUsuarios()
        {
            InitializeComponent();
            servicioUsuario = new ServicioUsuario();
            servicioRol = new ServicioRol();
            
            PoblarComboBoxRol();
            PoblarComboBoxEstado();
        }


        private void PoblarComboBoxEstado()
        {
            
            comboBoxEstado.Items.Add(new KeyValuePair<bool, string>(true, "Activo"));
            comboBoxEstado.Items.Add(new KeyValuePair<bool, string>(false, "Inactivo"));
            comboBoxEstado.DisplayMember = "Value";
            comboBoxEstado.ValueMember = "Key";
        }

        private void PoblarComboBoxRol()
        {
     
            comboBoxRol.Items.Add(new KeyValuePair<int, string>(1, "Administrador"));
            comboBoxRol.Items.Add(new KeyValuePair<int, string>(2, "Usuario"));
            comboBoxRol.DisplayMember = "Value";
            comboBoxRol.ValueMember = "Key";
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
       


       


        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            try
            {
            
                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseñaUsuario.Text;

                if (comboBoxEstado.SelectedItem == null || comboBoxRol.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona el estado y el rol del usuario.");
                    return;
                }

                
                var estadoPair = (KeyValuePair<bool, string>)comboBoxEstado.SelectedItem;
                var rolPair = (KeyValuePair<int, string>)comboBoxRol.SelectedItem;

                bool estado = estadoPair.Key;
                int idRol = rolPair.Key;

               
                Usuario usuario = new Usuario
                {
                    Nombre = nombreUsuario,
                    Contraseña = contraseña,
                    Estado = estado,
                    IdRol = idRol,
                    FechaCreacion = DateTime.Now 
                };

               
                bool registrado = servicioUsuario.Crear(usuario);

              
                if (registrado)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.");
                }

                
                txtNombreUsuario.Clear();
                txtContraseñaUsuario.Clear();
                comboBoxEstado.SelectedIndex = -1;
                comboBoxRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Mostrar() 
        {
            List<Usuario> usuarios = servicioUsuario.Listar();


            dataGridGestionUsuarios.DataSource = usuarios;

        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text;

                
                Usuario usuario = servicioUsuario.Listar().FirstOrDefault(u => u.Nombre.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

                if (usuario != null)
                {
                    bool eliminado = servicioUsuario.Eliminar(usuario.IdUsuario);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        Mostrar();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }

                
                txtNombreUsuario.Clear();
                txtContraseñaUsuario.Clear();
                comboBoxEstado.SelectedIndex = -1;
                comboBoxRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text;
                Usuario usuario = servicioUsuario.Listar().FirstOrDefault(u => u.Nombre.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

                if (usuario != null)
                {
                    string nuevaContraseña = txtContraseñaUsuario.Text;
                    bool nuevoEstado = ((KeyValuePair<bool, string>)comboBoxEstado.SelectedItem).Key;
                    int nuevoIdRol = ((KeyValuePair<int, string>)comboBoxRol.SelectedItem).Key;

                    usuario.Contraseña = nuevaContraseña;
                    usuario.Estado = nuevoEstado;
                    usuario.IdRol = nuevoIdRol;

                    bool actualizado = servicioUsuario.Actualizar(usuario);

                    if (actualizado)
                    {
                        MessageBox.Show("Usuario actualizado correctamente.");
                        Mostrar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }

                txtNombreUsuario.Clear();
                txtContraseñaUsuario.Clear();
                comboBoxEstado.SelectedIndex = -1;
                comboBoxRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
