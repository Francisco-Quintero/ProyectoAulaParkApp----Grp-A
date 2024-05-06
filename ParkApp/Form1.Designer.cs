namespace ParkApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnCerrarL = new System.Windows.Forms.PictureBox();
            this.btnMinizarL = new System.Windows.Forms.PictureBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizarL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.btnCerrarL);
            this.panel1.Controls.Add(this.btnMinizarL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 50);
            this.panel1.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfecha.Location = new System.Drawing.Point(3, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(64, 25);
            this.lblfecha.TabIndex = 14;
            this.lblfecha.Text = "label3";
            // 
            // btnCerrarL
            // 
            this.btnCerrarL.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarL.Image")));
            this.btnCerrarL.Location = new System.Drawing.Point(457, 0);
            this.btnCerrarL.Name = "btnCerrarL";
            this.btnCerrarL.Size = new System.Drawing.Size(40, 50);
            this.btnCerrarL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarL.TabIndex = 2;
            this.btnCerrarL.TabStop = false;
            this.btnCerrarL.Click += new System.EventHandler(this.btnCerrarL_Click);
            // 
            // btnMinizarL
            // 
            this.btnMinizarL.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizarL.Image")));
            this.btnMinizarL.Location = new System.Drawing.Point(406, 3);
            this.btnMinizarL.Name = "btnMinizarL";
            this.btnMinizarL.Size = new System.Drawing.Size(45, 50);
            this.btnMinizarL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizarL.TabIndex = 1;
            this.btnMinizarL.TabStop = false;
            this.btnMinizarL.Click += new System.EventHandler(this.btnMinizarL_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(49, 386);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(403, 25);
            this.txtcontraseña.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(49, 283);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(403, 25);
            this.txtusuario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(45, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "USUARIO";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblhora.Location = new System.Drawing.Point(114, 568);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(126, 46);
            this.lblhora.TabIndex = 15;
            this.lblhora.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 20);
            this.panel2.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(49, 459);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(403, 70);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "INGRESAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(497, 669);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizarL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.PictureBox btnCerrarL;
        private System.Windows.Forms.PictureBox btnMinizarL;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timer1;
    }
}

