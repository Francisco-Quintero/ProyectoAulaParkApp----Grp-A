namespace ParkApp
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.btnBuscarEstacionado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaEstacionado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridEstacionados = new System.Windows.Forms.DataGridView();
            this.PlacaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeVihiculoEstacionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoEstacionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIngresoEstacionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBVehiculosEstacionados = new System.Windows.Forms.ComboBox();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.btnCancelarM = new System.Windows.Forms.PictureBox();
            this.btnMenuEx = new System.Windows.Forms.PictureBox();
            this.btnTipoVehiculo = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnHistorialingresos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.bntHistorialSalidas = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.MenuVertical.Controls.Add(this.btnTipoVehiculo);
            this.MenuVertical.Controls.Add(this.btnNuevoUsuario);
            this.MenuVertical.Controls.Add(this.btnHistorialingresos);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.pictureBox3);
            this.MenuVertical.Controls.Add(this.btnSalida);
            this.MenuVertical.Controls.Add(this.bntHistorialSalidas);
            this.MenuVertical.Controls.Add(this.btnIngreso);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(333, 650);
            this.MenuVertical.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Park App";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.pictureBox5);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.btnCancelarM);
            this.BarraTitulo.Controls.Add(this.btnMenuEx);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(333, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(967, 45);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelformularios.Controls.Add(this.btnBuscarEstacionado);
            this.panelformularios.Controls.Add(this.label2);
            this.panelformularios.Controls.Add(this.txtBusquedaEstacionado);
            this.panelformularios.Controls.Add(this.label11);
            this.panelformularios.Controls.Add(this.dataGridEstacionados);
            this.panelformularios.Controls.Add(this.CBVehiculosEstacionados);
            this.panelformularios.Controls.Add(this.lblEntradas);
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.ForeColor = System.Drawing.Color.White;
            this.panelformularios.Location = new System.Drawing.Point(333, 45);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(967, 605);
            this.panelformularios.TabIndex = 3;
            this.panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnBuscarEstacionado
            // 
            this.btnBuscarEstacionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarEstacionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnBuscarEstacionado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstacionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstacionado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstacionado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstacionado.Location = new System.Drawing.Point(344, 102);
            this.btnBuscarEstacionado.Name = "btnBuscarEstacionado";
            this.btnBuscarEstacionado.Size = new System.Drawing.Size(195, 35);
            this.btnBuscarEstacionado.TabIndex = 57;
            this.btnBuscarEstacionado.Text = "BUSCAR";
            this.btnBuscarEstacionado.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Filtrar por tipo";
            // 
            // txtBusquedaEstacionado
            // 
            this.txtBusquedaEstacionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaEstacionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtBusquedaEstacionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaEstacionado.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaEstacionado.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaEstacionado.Location = new System.Drawing.Point(538, 36);
            this.txtBusquedaEstacionado.Name = "txtBusquedaEstacionado";
            this.txtBusquedaEstacionado.Size = new System.Drawing.Size(245, 23);
            this.txtBusquedaEstacionado.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(534, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "BUSCAR POR PLACA";
            // 
            // dataGridEstacionados
            // 
            this.dataGridEstacionados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridEstacionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridEstacionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEstacionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEstacionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlacaEntrada,
            this.TipoDeVihiculoEstacionado,
            this.FechaIngresoEstacionado,
            this.HoraIngresoEstacionado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEstacionados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEstacionados.EnableHeadersVisualStyles = false;
            this.dataGridEstacionados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridEstacionados.Location = new System.Drawing.Point(146, 241);
            this.dataGridEstacionados.Name = "dataGridEstacionados";
            this.dataGridEstacionados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEstacionados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridEstacionados.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridEstacionados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridEstacionados.RowTemplate.Height = 24;
            this.dataGridEstacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstacionados.Size = new System.Drawing.Size(768, 361);
            this.dataGridEstacionados.TabIndex = 35;
            this.dataGridEstacionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEstacionados_CellContentClick);
            // 
            // PlacaEntrada
            // 
            this.PlacaEntrada.HeaderText = "Placa Del Vehiculo";
            this.PlacaEntrada.MinimumWidth = 6;
            this.PlacaEntrada.Name = "PlacaEntrada";
            this.PlacaEntrada.Width = 125;
            // 
            // TipoDeVihiculoEstacionado
            // 
            this.TipoDeVihiculoEstacionado.HeaderText = "Tipo De Vehiculo";
            this.TipoDeVihiculoEstacionado.MinimumWidth = 6;
            this.TipoDeVihiculoEstacionado.Name = "TipoDeVihiculoEstacionado";
            this.TipoDeVihiculoEstacionado.Width = 125;
            // 
            // FechaIngresoEstacionado
            // 
            this.FechaIngresoEstacionado.HeaderText = "Fecha De Ingreso";
            this.FechaIngresoEstacionado.MinimumWidth = 6;
            this.FechaIngresoEstacionado.Name = "FechaIngresoEstacionado";
            this.FechaIngresoEstacionado.Width = 125;
            // 
            // HoraIngresoEstacionado
            // 
            this.HoraIngresoEstacionado.HeaderText = "Hora De Ingreso";
            this.HoraIngresoEstacionado.MinimumWidth = 6;
            this.HoraIngresoEstacionado.Name = "HoraIngresoEstacionado";
            this.HoraIngresoEstacionado.Width = 125;
            // 
            // CBVehiculosEstacionados
            // 
            this.CBVehiculosEstacionados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBVehiculosEstacionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.CBVehiculosEstacionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBVehiculosEstacionados.ForeColor = System.Drawing.Color.White;
            this.CBVehiculosEstacionados.FormattingEnabled = true;
            this.CBVehiculosEstacionados.Items.AddRange(new object[] {
            "AUTOMOVILES",
            "MOTOCICLETAS",
            "TODOS"});
            this.CBVehiculosEstacionados.Location = new System.Drawing.Point(98, 35);
            this.CBVehiculosEstacionados.Name = "CBVehiculosEstacionados";
            this.CBVehiculosEstacionados.Size = new System.Drawing.Size(245, 24);
            this.CBVehiculosEstacionados.TabIndex = 37;
            this.CBVehiculosEstacionados.SelectedIndexChanged += new System.EventHandler(this.CBVehiculosEstacionados_SelectedIndexChanged);
            // 
            // lblEntradas
            // 
            this.lblEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.Color.White;
            this.lblEntradas.Location = new System.Drawing.Point(214, 190);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(453, 36);
            this.lblEntradas.TabIndex = 36;
            this.lblEntradas.Text = "VEHICULOS ESTACIONADOS";
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Image = global::ParkApp.Properties.Resources.icons8_minimizar_la_ventana_50;
            this.iconrestaurar.Location = new System.Drawing.Point(879, 7);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(35, 35);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 2;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::ParkApp.Properties.Resources.icons8_minimizar_50;
            this.pictureBox5.Location = new System.Drawing.Point(838, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Image = global::ParkApp.Properties.Resources.icons8_alternar_pantalla_completa_50;
            this.iconmaximizar.Location = new System.Drawing.Point(879, 3);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(35, 35);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 1;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarM.Image = global::ParkApp.Properties.Resources.icons8_eliminar_48;
            this.btnCancelarM.Location = new System.Drawing.Point(920, 3);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(35, 35);
            this.btnCancelarM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarM.TabIndex = 0;
            this.btnCancelarM.TabStop = false;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnMenuEx
            // 
            this.btnMenuEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuEx.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuEx.Image")));
            this.btnMenuEx.Location = new System.Drawing.Point(27, 4);
            this.btnMenuEx.Name = "btnMenuEx";
            this.btnMenuEx.Size = new System.Drawing.Size(35, 35);
            this.btnMenuEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuEx.TabIndex = 0;
            this.btnMenuEx.TabStop = false;
            this.btnMenuEx.Click += new System.EventHandler(this.btnMenuEx_Click);
            // 
            // btnTipoVehiculo
            // 
            this.btnTipoVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnTipoVehiculo.FlatAppearance.BorderSize = 0;
            this.btnTipoVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnTipoVehiculo.Image = global::ParkApp.Properties.Resources.trafico__1_;
            this.btnTipoVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoVehiculo.Location = new System.Drawing.Point(24, 520);
            this.btnTipoVehiculo.Name = "btnTipoVehiculo";
            this.btnTipoVehiculo.Size = new System.Drawing.Size(250, 40);
            this.btnTipoVehiculo.TabIndex = 29;
            this.btnTipoVehiculo.Text = "NUEVO VEHICULO";
            this.btnTipoVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoVehiculo.UseVisualStyleBackColor = false;
            this.btnTipoVehiculo.Click += new System.EventHandler(this.btnTipoVehiculo_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Image = global::ParkApp.Properties.Resources.agregar_usuario;
            this.btnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(24, 440);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(250, 40);
            this.btnNuevoUsuario.TabIndex = 28;
            this.btnNuevoUsuario.Text = "NUEVO USUARIO";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnHistorialingresos
            // 
            this.btnHistorialingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnHistorialingresos.FlatAppearance.BorderSize = 0;
            this.btnHistorialingresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHistorialingresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialingresos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialingresos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialingresos.Image = global::ParkApp.Properties.Resources.historial_ingresos;
            this.btnHistorialingresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialingresos.Location = new System.Drawing.Point(24, 362);
            this.btnHistorialingresos.Name = "btnHistorialingresos";
            this.btnHistorialingresos.Size = new System.Drawing.Size(250, 40);
            this.btnHistorialingresos.TabIndex = 27;
            this.btnHistorialingresos.Text = "INFORME INGRESO";
            this.btnHistorialingresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorialingresos.UseVisualStyleBackColor = false;
            this.btnHistorialingresos.Click += new System.EventHandler(this.btnHistorialIngresos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Image = global::ParkApp.Properties.Resources.salidas;
            this.btnSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalida.Location = new System.Drawing.Point(24, 213);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(250, 40);
            this.btnSalida.TabIndex = 25;
            this.btnSalida.Text = "SALIDAS";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.button5_Click);
            // 
            // bntHistorialSalidas
            // 
            this.bntHistorialSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.bntHistorialSalidas.FlatAppearance.BorderSize = 0;
            this.bntHistorialSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bntHistorialSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHistorialSalidas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHistorialSalidas.ForeColor = System.Drawing.Color.White;
            this.bntHistorialSalidas.Image = global::ParkApp.Properties.Resources.HISTORIAL_SALIDAS;
            this.bntHistorialSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntHistorialSalidas.Location = new System.Drawing.Point(24, 286);
            this.bntHistorialSalidas.Name = "bntHistorialSalidas";
            this.bntHistorialSalidas.Size = new System.Drawing.Size(250, 40);
            this.bntHistorialSalidas.TabIndex = 18;
            this.bntHistorialSalidas.Text = "HISTORIAL SALIDA";
            this.bntHistorialSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntHistorialSalidas.UseVisualStyleBackColor = false;
            this.bntHistorialSalidas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Image = global::ParkApp.Properties.Resources.iniciar_sesion;
            this.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngreso.Location = new System.Drawing.Point(24, 142);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(250, 40);
            this.btnIngreso.TabIndex = 16;
            this.btnIngreso.Text = "INGRESOS";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelformularios);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            this.panelformularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button bntHistorialSalidas;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox btnMenuEx;
        private System.Windows.Forms.PictureBox btnCancelarM;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Button btnHistorialingresos;
        public System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.ComboBox CBVehiculosEstacionados;
        private System.Windows.Forms.DataGridView dataGridEstacionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeVihiculoEstacionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoEstacionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIngresoEstacionado;
        private System.Windows.Forms.TextBox txtBusquedaEstacionado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBuscarEstacionado;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnTipoVehiculo;
    }
}