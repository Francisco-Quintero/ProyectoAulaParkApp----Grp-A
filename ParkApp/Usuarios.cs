using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ParkApp
{
    public partial class Usuarios : Form
    {

        private ServicioUsuario servicioUsuario;
        private ServicioRol servicioRol;
        //private ServicioPersona servicioPersona;
        public Usuarios()
        {
            InitializeComponent();
            servicioUsuario = new ServicioUsuario();
            servicioRol = new ServicioRol();

        }


        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void PoblarComboBoxEstado()
        {
            // Suponiendo que los estados son Activo e Inactivo
            comboBoxEstado.Items.Add(new KeyValuePair<bool, string>(true, "Activo"));
            comboBoxEstado.Items.Add(new KeyValuePair<bool, string>(false, "Inactivo"));
            comboBoxEstado.DisplayMember = "Value";
            comboBoxEstado.ValueMember = "Key";
        }


        //private void PoblarComboBoxRol()
        //{
        //    // Aquí debes cargar los roles desde la base de datos o definirlos manualmente
        //    comboBoxRol.Items.Add(new KeyValuePair<int, string>(1, "Administrador"));
        //    comboBoxRol.Items.Add(new KeyValuePair<int, string>(2, "Usuario"));
        //    comboBoxRol.DisplayMember = "Value";
        //    comboBoxRol.ValueMember = "Key";
        //}


        private void btnRegistrar_Click(object sender, EventArgs e)
        {




            String NombreUsuario = txtNombreUsuario.Text;
            String Contraseña = txtContraseñaUsuario.Text;
        
            String Estado = comboBoxEstado.SelectedText;
            String Rol = comboBoxRol.SelectedText;



            //string TipoVehiculo = comboBox1.SelectedItem.ToString();
            ENTITY.Usuario usuario = new ENTITY.Usuario(NombreUsuario, Contraseña);
            ENTITY.Rol rol = new ENTITY.Rol(Rol, Estado);

            servicioUsuario.Crear(usuario);
            servicioRol.Crear(rol);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
