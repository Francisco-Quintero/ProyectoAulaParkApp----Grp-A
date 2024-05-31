namespace ParkApp
{
    partial class InformeIngresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.dataGridEntradas = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerIngresos = new System.Windows.Forms.DateTimePicker();
            this.txtBusquedaPlacaIngresos = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarHEntradas = new System.Windows.Forms.Button();
            this.btnCerrarPingreso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filtros";
            // 
            // lblEntradas
            // 
            this.lblEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.Color.White;
            this.lblEntradas.Location = new System.Drawing.Point(308, 217);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(430, 36);
            this.lblEntradas.TabIndex = 35;
            this.lblEntradas.Text = "ENTRADAS DE VEHICULOS";
            // 
            // dataGridEntradas
            // 
            this.dataGridEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.TipoVehiculo,
            this.FechaIngreso,
            this.HoraIngreso});
            this.dataGridEntradas.EnableHeadersVisualStyles = false;
            this.dataGridEntradas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridEntradas.Location = new System.Drawing.Point(195, 256);
            this.dataGridEntradas.Name = "dataGridEntradas";
            this.dataGridEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEntradas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridEntradas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEntradas.RowTemplate.Height = 24;
            this.dataGridEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntradas.Size = new System.Drawing.Size(737, 310);
            this.dataGridEntradas.TabIndex = 34;
            this.dataGridEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEntradas_CellContentClick);
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
            // dateTimePickerIngresos
            // 
            this.dateTimePickerIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIngresos.Location = new System.Drawing.Point(206, 53);
            this.dateTimePickerIngresos.Name = "dateTimePickerIngresos";
            this.dateTimePickerIngresos.Size = new System.Drawing.Size(277, 22);
            this.dateTimePickerIngresos.TabIndex = 40;
            // 
            // txtBusquedaPlacaIngresos
            // 
            this.txtBusquedaPlacaIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaPlacaIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtBusquedaPlacaIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaPlacaIngresos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBusquedaPlacaIngresos.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaPlacaIngresos.Location = new System.Drawing.Point(420, 117);
            this.txtBusquedaPlacaIngresos.Name = "txtBusquedaPlacaIngresos";
            this.txtBusquedaPlacaIngresos.Size = new System.Drawing.Size(259, 23);
            this.txtBusquedaPlacaIngresos.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AUTOMOVILES",
            "MOTOCICLETAS",
            "TODOS"});
            this.comboBox1.Location = new System.Drawing.Point(601, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "TIPO DE VEHICULO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "PLACA";
            // 
            // btnBuscarHEntradas
            // 
            this.btnBuscarHEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarHEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnBuscarHEntradas.FlatAppearance.BorderSize = 0;
            this.btnBuscarHEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHEntradas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHEntradas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHEntradas.Location = new System.Drawing.Point(456, 144);
            this.btnBuscarHEntradas.Name = "btnBuscarHEntradas";
            this.btnBuscarHEntradas.Size = new System.Drawing.Size(195, 35);
            this.btnBuscarHEntradas.TabIndex = 59;
            this.btnBuscarHEntradas.Text = "BUSCAR";
            this.btnBuscarHEntradas.UseVisualStyleBackColor = false;
            // 
            // btnCerrarPingreso
            // 
            this.btnCerrarPingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPingreso.Image = global::ParkApp.Properties.Resources.icons8_eliminar_48;
            this.btnCerrarPingreso.Location = new System.Drawing.Point(1123, 12);
            this.btnCerrarPingreso.Name = "btnCerrarPingreso";
            this.btnCerrarPingreso.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarPingreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarPingreso.TabIndex = 39;
            this.btnCerrarPingreso.TabStop = false;
            this.btnCerrarPingreso.Click += new System.EventHandler(this.btnCerrarPingreso_Click);
            // 
            // InformeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.btnBuscarHEntradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBusquedaPlacaIngresos);
            this.Controls.Add(this.dateTimePickerIngresos);
            this.Controls.Add(this.btnCerrarPingreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.dataGridEntradas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeIngresos";
            this.Text = "InformeIngresos";
            this.Load += new System.EventHandler(this.InformeIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPingreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.DataGridView dataGridEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIngreso;
        private System.Windows.Forms.PictureBox btnCerrarPingreso;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngresos;
        private System.Windows.Forms.TextBox txtBusquedaPlacaIngresos;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnBuscarHEntradas;
    }
}