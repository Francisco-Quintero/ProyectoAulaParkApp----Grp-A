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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.dataGridEntradas = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(157, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(157, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filtros";
            // 
            // lblEntradas
            // 
            this.lblEntradas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntradas.Location = new System.Drawing.Point(281, 152);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(409, 36);
            this.lblEntradas.TabIndex = 35;
            this.lblEntradas.Text = "ENTRADAS DE VEHICULOS";
            // 
            // dataGridEntradas
            // 
            this.dataGridEntradas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridEntradas.Location = new System.Drawing.Point(149, 215);
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
            // InformeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1034, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.dataGridEntradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeIngresos";
            this.Text = "InformeIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.DataGridView dataGridEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIngreso;
    }
}