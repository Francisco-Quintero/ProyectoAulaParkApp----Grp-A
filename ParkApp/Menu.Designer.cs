namespace ParkApp
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dataGridEstacionados = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.btnMenuEx = new System.Windows.Forms.PictureBox();
            this.btnCancelarM = new System.Windows.Forms.PictureBox();
            this.btnHistorialIngresos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bntHistorialSalidas = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.MenuVertical.Controls.Add(this.btnHistorialIngresos);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.pictureBox3);
            this.MenuVertical.Controls.Add(this.button5);
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
            this.BarraTitulo.Controls.Add(this.btnMenuEx);
            this.BarraTitulo.Controls.Add(this.btnCancelarM);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(333, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(967, 45);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelContenedor.Controls.Add(this.comboBox1);
            this.panelContenedor.Controls.Add(this.lblEntradas);
            this.panelContenedor.Controls.Add(this.dataGridEstacionados);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(333, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(967, 605);
            this.panelContenedor.TabIndex = 3;
            // 
            // dataGridEstacionados
            // 
            this.dataGridEstacionados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridEstacionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridEstacionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEstacionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEstacionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.TipoVehiculo,
            this.FechaIngreso,
            this.HoraIngreso});
            this.dataGridEstacionados.EnableHeadersVisualStyles = false;
            this.dataGridEstacionados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridEstacionados.Location = new System.Drawing.Point(177, 173);
            this.dataGridEstacionados.Name = "dataGridEstacionados";
            this.dataGridEstacionados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEstacionados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEstacionados.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridEstacionados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEstacionados.RowTemplate.Height = 24;
            this.dataGridEstacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstacionados.Size = new System.Drawing.Size(737, 310);
            this.dataGridEstacionados.TabIndex = 35;
            this.dataGridEstacionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEntradas_CellContentClick);
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa del Vehiculo";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.Width = 125;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.HeaderText = "Tipo de Vehiculo";
            this.TipoVehiculo.MinimumWidth = 6;
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.Width = 125;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 125;
            // 
            // HoraIngreso
            // 
            this.HoraIngreso.HeaderText = "Hora de Ingreso";
            this.HoraIngreso.MinimumWidth = 6;
            this.HoraIngreso.Name = "HoraIngreso";
            this.HoraIngreso.Width = 125;
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(879, 4);
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
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
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
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(879, 3);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(35, 35);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 1;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
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
            // btnCancelarM
            // 
            this.btnCancelarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarM.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarM.Image")));
            this.btnCancelarM.Location = new System.Drawing.Point(920, 3);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(35, 35);
            this.btnCancelarM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarM.TabIndex = 0;
            this.btnCancelarM.TabStop = false;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnHistorialIngresos
            // 
            this.btnHistorialIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.btnHistorialIngresos.FlatAppearance.BorderSize = 0;
            this.btnHistorialIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHistorialIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialIngresos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialIngresos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialIngresos.Image = global::ParkApp.Properties.Resources.historial_ingresos;
            this.btnHistorialIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialIngresos.Location = new System.Drawing.Point(24, 426);
            this.btnHistorialIngresos.Name = "btnHistorialIngresos";
            this.btnHistorialIngresos.Size = new System.Drawing.Size(250, 40);
            this.btnHistorialIngresos.TabIndex = 27;
            this.btnHistorialIngresos.Text = "INFORME INGRESO";
            this.btnHistorialIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorialIngresos.UseVisualStyleBackColor = false;
            this.btnHistorialIngresos.Click += new System.EventHandler(this.btnHistorialIngresos_Click);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ParkApp.Properties.Resources.salidas;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(24, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "SALIDAS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.bntHistorialSalidas.Location = new System.Drawing.Point(24, 340);
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
            this.btnIngreso.Location = new System.Drawing.Point(24, 160);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(250, 40);
            this.btnIngreso.TabIndex = 16;
            this.btnIngreso.Text = "INGRESOS";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntradas.Location = new System.Drawing.Point(253, 108);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(453, 36);
            this.lblEntradas.TabIndex = 36;
            this.lblEntradas.Text = "VEHICULOS ESTACIONADOS";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AUTOMOVILES",
            "MOTOCICLETAS"});
            this.comboBox1.Location = new System.Drawing.Point(38, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bntHistorialSalidas;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox btnMenuEx;
        private System.Windows.Forms.PictureBox btnCancelarM;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dataGridEstacionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIngreso;
        private System.Windows.Forms.Button btnHistorialIngresos;
        public System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}