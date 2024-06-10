namespace ParkApp
{
    partial class FrmInformeSalidas
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
            this.dateTimePickerSalidas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSalidasVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.btnCerrarSalidasVe = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarHSalidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalidasVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSalidasVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // dateTimePickerSalidas
            // 
            this.dateTimePickerSalidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerSalidas.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSalidas.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerSalidas.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.dateTimePickerSalidas.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerSalidas.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePickerSalidas.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerSalidas.Location = new System.Drawing.Point(239, 53);
            this.dateTimePickerSalidas.Name = "dateTimePickerSalidas";
            this.dateTimePickerSalidas.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerSalidas.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Filtros";
            // 
            // dataGridSalidasVehiculos
            // 
            this.dataGridSalidasVehiculos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridSalidasVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridSalidasVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSalidasVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalidasVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSalidasVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalidasVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.FechaSalida,
            this.HoraSalida});
            this.dataGridSalidasVehiculos.EnableHeadersVisualStyles = false;
            this.dataGridSalidasVehiculos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridSalidasVehiculos.Location = new System.Drawing.Point(42, 276);
            this.dataGridSalidasVehiculos.Name = "dataGridSalidasVehiculos";
            this.dataGridSalidasVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalidasVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSalidasVehiculos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSalidasVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSalidasVehiculos.RowTemplate.Height = 24;
            this.dataGridSalidasVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSalidasVehiculos.Size = new System.Drawing.Size(1086, 310);
            this.dataGridSalidasVehiculos.TabIndex = 39;
            this.dataGridSalidasVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalidasVehiculos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa del Vehiculo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Vehiculo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de Ingreso";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora de Ingreso";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha de Salida";
            this.FechaSalida.MinimumWidth = 6;
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Width = 125;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora de Salida";
            this.HoraSalida.MinimumWidth = 6;
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.Width = 125;
            // 
            // lblSalidas
            // 
            this.lblSalidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidas.ForeColor = System.Drawing.Color.White;
            this.lblSalidas.Location = new System.Drawing.Point(390, 219);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(392, 36);
            this.lblSalidas.TabIndex = 38;
            this.lblSalidas.Text = "SALIDAS DE VEHICULOS";
            // 
            // btnCerrarSalidasVe
            // 
            this.btnCerrarSalidasVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSalidasVe.Image = global::ParkApp.Properties.Resources.icons8_eliminar_48;
            this.btnCerrarSalidasVe.Location = new System.Drawing.Point(1123, 12);
            this.btnCerrarSalidasVe.Name = "btnCerrarSalidasVe";
            this.btnCerrarSalidasVe.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarSalidasVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSalidasVe.TabIndex = 43;
            this.btnCerrarSalidasVe.TabStop = false;
            this.btnCerrarSalidasVe.Click += new System.EventHandler(this.btnCerrarSalidasVe_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AUTOMOVIL",
            "MOTOCICLETA"});
            this.comboBox1.Location = new System.Drawing.Point(616, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(612, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "TIPO DE VEHICULO";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(420, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 23);
            this.textBox1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "PLACA";
            // 
            // btnBuscarHSalidas
            // 
            this.btnBuscarHSalidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarHSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnBuscarHSalidas.FlatAppearance.BorderSize = 0;
            this.btnBuscarHSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHSalidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHSalidas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHSalidas.Location = new System.Drawing.Point(466, 144);
            this.btnBuscarHSalidas.Name = "btnBuscarHSalidas";
            this.btnBuscarHSalidas.Size = new System.Drawing.Size(195, 35);
            this.btnBuscarHSalidas.TabIndex = 58;
            this.btnBuscarHSalidas.Text = "BUSCAR";
            this.btnBuscarHSalidas.UseVisualStyleBackColor = false;
            this.btnBuscarHSalidas.Click += new System.EventHandler(this.btnBuscarHSalidas_Click);
            // 
            // InformeSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.btnBuscarHSalidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCerrarSalidasVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerSalidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSalidasVehiculos);
            this.Controls.Add(this.lblSalidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeSalidas";
            this.Text = "InformeSalidas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalidasVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSalidasVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalidas;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSalidasVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        public System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.PictureBox btnCerrarSalidasVe;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnBuscarHSalidas;
    }
}