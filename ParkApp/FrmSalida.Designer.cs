namespace ParkApp
{
    partial class FrmSalida
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
            this.txtPlacaSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCerrarPsalida = new System.Windows.Forms.PictureBox();
            this.btnAutorizarSalida = new System.Windows.Forms.Button();
            this.dataGridSalidasVehiculo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPsalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalidasVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlacaSalida
            // 
            this.txtPlacaSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtPlacaSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlacaSalida.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaSalida.ForeColor = System.Drawing.Color.White;
            this.txtPlacaSalida.Location = new System.Drawing.Point(140, 239);
            this.txtPlacaSalida.Name = "txtPlacaSalida";
            this.txtPlacaSalida.Size = new System.Drawing.Size(298, 29);
            this.txtPlacaSalida.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "PLACA";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(280, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(595, 44);
            this.label10.TabIndex = 43;
            this.label10.Text = "AUTORIZAR SALIDA DE VEHICULO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnCerrarPsalida
            // 
            this.btnCerrarPsalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPsalida.Image = global::ParkApp.Properties.Resources.icons8_eliminar_48;
            this.btnCerrarPsalida.Location = new System.Drawing.Point(1123, 12);
            this.btnCerrarPsalida.Name = "btnCerrarPsalida";
            this.btnCerrarPsalida.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarPsalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarPsalida.TabIndex = 61;
            this.btnCerrarPsalida.TabStop = false;
            this.btnCerrarPsalida.Click += new System.EventHandler(this.btnCerrarPsalida_Click);
            // 
            // btnAutorizarSalida
            // 
            this.btnAutorizarSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutorizarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnAutorizarSalida.FlatAppearance.BorderSize = 0;
            this.btnAutorizarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizarSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizarSalida.ForeColor = System.Drawing.Color.White;
            this.btnAutorizarSalida.Location = new System.Drawing.Point(146, 274);
            this.btnAutorizarSalida.Name = "btnAutorizarSalida";
            this.btnAutorizarSalida.Size = new System.Drawing.Size(280, 54);
            this.btnAutorizarSalida.TabIndex = 62;
            this.btnAutorizarSalida.Text = "AUTORIZAR SALIDA";
            this.btnAutorizarSalida.UseVisualStyleBackColor = false;
            this.btnAutorizarSalida.Click += new System.EventHandler(this.btnAutorizarSalida_Click);
            // 
            // dataGridSalidasVehiculo
            // 
            this.dataGridSalidasVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridSalidasVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridSalidasVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridSalidasVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSalidasVehiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalidasVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridSalidasVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSalidasVehiculo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSalidasVehiculo.EnableHeadersVisualStyles = false;
            this.dataGridSalidasVehiculo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridSalidasVehiculo.Location = new System.Drawing.Point(483, 174);
            this.dataGridSalidasVehiculo.Name = "dataGridSalidasVehiculo";
            this.dataGridSalidasVehiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalidasVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridSalidasVehiculo.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSalidasVehiculo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridSalidasVehiculo.RowTemplate.Height = 24;
            this.dataGridSalidasVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSalidasVehiculo.Size = new System.Drawing.Size(643, 381);
            this.dataGridSalidasVehiculo.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 37);
            this.label2.TabIndex = 73;
            this.label2.Text = "VEHICULOS DENTRO DEL PARQUEADERO";
            // 
            // FrmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridSalidasVehiculo);
            this.Controls.Add(this.btnAutorizarSalida);
            this.Controls.Add(this.btnCerrarPsalida);
            this.Controls.Add(this.txtPlacaSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalida";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.FrmSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPsalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalidasVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlacaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnCerrarPsalida;
        private System.Windows.Forms.Button btnAutorizarSalida;
        public System.Windows.Forms.DataGridView dataGridSalidasVehiculo;
        private System.Windows.Forms.Label label2;
    }
}