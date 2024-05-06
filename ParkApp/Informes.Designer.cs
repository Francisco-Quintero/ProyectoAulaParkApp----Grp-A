namespace ParkApp
{
    partial class Informes
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
            this.btnInformeSalida = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformeSalida
            // 
            this.btnInformeSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInformeSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnInformeSalida.FlatAppearance.BorderSize = 0;
            this.btnInformeSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeSalida.ForeColor = System.Drawing.Color.White;
            this.btnInformeSalida.Location = new System.Drawing.Point(198, 114);
            this.btnInformeSalida.Name = "btnInformeSalida";
            this.btnInformeSalida.Size = new System.Drawing.Size(403, 70);
            this.btnInformeSalida.TabIndex = 34;
            this.btnInformeSalida.Text = "SALIDAS DE VEHICULOS";
            this.btnInformeSalida.UseVisualStyleBackColor = false;
            this.btnInformeSalida.Click += new System.EventHandler(this.btnInformeSalida_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Location = new System.Drawing.Point(198, 234);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(403, 70);
            this.btnIngresos.TabIndex = 35;
            this.btnIngresos.Text = "INGRESOS DE VEHICULOS";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnInformeSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnInformeSalida;
        public System.Windows.Forms.Button btnIngresos;
    }
}