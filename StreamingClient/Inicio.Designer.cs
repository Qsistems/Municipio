namespace StreamingClient
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnlConectar = new System.Windows.Forms.Panel();
            this.lblConectar = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblDireccionIP = new System.Windows.Forms.Label();
            this.lblAbrirConfigurar = new System.Windows.Forms.Label();
            this.lblMinimizar1 = new System.Windows.Forms.Label();
            this.lblCerrar1 = new System.Windows.Forms.Label();
            this.pnlConfiguracion = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtDireccionIp = new System.Windows.Forms.TextBox();
            this.lblMinimizar2 = new System.Windows.Forms.Label();
            this.lblCerrar2 = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblCerrarConfiguracion = new System.Windows.Forms.Label();
            this.pnlIntentandoConexion = new System.Windows.Forms.Panel();
            this.lblIntentandoConectar = new System.Windows.Forms.Label();
            this.tmProcesos = new System.Windows.Forms.Timer(this.components);
            this.tmNavegadorVisible = new System.Windows.Forms.Timer(this.components);
            this.pnlConectar.SuspendLayout();
            this.pnlConfiguracion.SuspendLayout();
            this.pnlIntentandoConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConectar
            // 
            this.pnlConectar.BackColor = System.Drawing.Color.Coral;
            this.pnlConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConectar.BackgroundImage")));
            this.pnlConectar.Controls.Add(this.lblConectar);
            this.pnlConectar.Controls.Add(this.lblUrl);
            this.pnlConectar.Controls.Add(this.lblPuerto);
            this.pnlConectar.Controls.Add(this.lblDireccionIP);
            this.pnlConectar.Controls.Add(this.lblAbrirConfigurar);
            this.pnlConectar.Controls.Add(this.lblMinimizar1);
            this.pnlConectar.Controls.Add(this.lblCerrar1);
            this.pnlConectar.Location = new System.Drawing.Point(12, 12);
            this.pnlConectar.Name = "pnlConectar";
            this.pnlConectar.Size = new System.Drawing.Size(389, 219);
            this.pnlConectar.TabIndex = 0;
            this.pnlConectar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlConectar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblConectar
            // 
            this.lblConectar.AutoSize = true;
            this.lblConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectar.ForeColor = System.Drawing.Color.White;
            this.lblConectar.Location = new System.Drawing.Point(150, 190);
            this.lblConectar.Name = "lblConectar";
            this.lblConectar.Size = new System.Drawing.Size(94, 24);
            this.lblConectar.TabIndex = 6;
            this.lblConectar.Text = "Conectar";
            this.lblConectar.Click += new System.EventHandler(this.lblConectar_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.White;
            this.lblUrl.Location = new System.Drawing.Point(203, 151);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(129, 20);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "192.169.123.234";
            this.lblUrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUrl_MouseDown);
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.ForeColor = System.Drawing.Color.White;
            this.lblPuerto.Location = new System.Drawing.Point(203, 107);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(129, 20);
            this.lblPuerto.TabIndex = 4;
            this.lblPuerto.Text = "192.169.123.234";
            this.lblPuerto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPuerto_MouseDown);
            // 
            // lblDireccionIP
            // 
            this.lblDireccionIP.AutoSize = true;
            this.lblDireccionIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionIP.ForeColor = System.Drawing.Color.White;
            this.lblDireccionIP.Location = new System.Drawing.Point(203, 61);
            this.lblDireccionIP.Name = "lblDireccionIP";
            this.lblDireccionIP.Size = new System.Drawing.Size(129, 20);
            this.lblDireccionIP.TabIndex = 3;
            this.lblDireccionIP.Text = "192.169.123.234";
            this.lblDireccionIP.Click += new System.EventHandler(this.lblDireccionIP_Click);
            this.lblDireccionIP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDireccionIP_MouseDown);
            // 
            // lblAbrirConfigurar
            // 
            this.lblAbrirConfigurar.AutoSize = true;
            this.lblAbrirConfigurar.Location = new System.Drawing.Point(296, 12);
            this.lblAbrirConfigurar.Name = "lblAbrirConfigurar";
            this.lblAbrirConfigurar.Size = new System.Drawing.Size(25, 13);
            this.lblAbrirConfigurar.TabIndex = 2;
            this.lblAbrirConfigurar.Text = "      ";
            this.lblAbrirConfigurar.Click += new System.EventHandler(this.lblConfigurar_Click);
            // 
            // lblMinimizar1
            // 
            this.lblMinimizar1.AutoSize = true;
            this.lblMinimizar1.Location = new System.Drawing.Point(341, 12);
            this.lblMinimizar1.Name = "lblMinimizar1";
            this.lblMinimizar1.Size = new System.Drawing.Size(13, 13);
            this.lblMinimizar1.TabIndex = 1;
            this.lblMinimizar1.Text = "  ";
            this.lblMinimizar1.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblCerrar1
            // 
            this.lblCerrar1.AutoSize = true;
            this.lblCerrar1.Location = new System.Drawing.Point(366, 12);
            this.lblCerrar1.Name = "lblCerrar1";
            this.lblCerrar1.Size = new System.Drawing.Size(13, 13);
            this.lblCerrar1.TabIndex = 0;
            this.lblCerrar1.Text = "  ";
            this.lblCerrar1.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // pnlConfiguracion
            // 
            this.pnlConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConfiguracion.BackgroundImage")));
            this.pnlConfiguracion.Controls.Add(this.txtUrl);
            this.pnlConfiguracion.Controls.Add(this.txtPuerto);
            this.pnlConfiguracion.Controls.Add(this.txtDireccionIp);
            this.pnlConfiguracion.Controls.Add(this.lblMinimizar2);
            this.pnlConfiguracion.Controls.Add(this.lblCerrar2);
            this.pnlConfiguracion.Controls.Add(this.lblGuardar);
            this.pnlConfiguracion.Controls.Add(this.lblCerrarConfiguracion);
            this.pnlConfiguracion.Location = new System.Drawing.Point(700, 370);
            this.pnlConfiguracion.Name = "pnlConfiguracion";
            this.pnlConfiguracion.Size = new System.Drawing.Size(609, 348);
            this.pnlConfiguracion.TabIndex = 1;
            this.pnlConfiguracion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlConfiguracion_MouseDown);
            // 
            // txtUrl
            // 
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.Color.White;
            this.txtUrl.Location = new System.Drawing.Point(190, 150);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(163, 22);
            this.txtUrl.TabIndex = 14;
            // 
            // txtPuerto
            // 
            this.txtPuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.ForeColor = System.Drawing.Color.White;
            this.txtPuerto.Location = new System.Drawing.Point(190, 107);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(163, 22);
            this.txtPuerto.TabIndex = 13;
            // 
            // txtDireccionIp
            // 
            this.txtDireccionIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionIp.ForeColor = System.Drawing.Color.White;
            this.txtDireccionIp.Location = new System.Drawing.Point(190, 62);
            this.txtDireccionIp.Name = "txtDireccionIp";
            this.txtDireccionIp.Size = new System.Drawing.Size(163, 22);
            this.txtDireccionIp.TabIndex = 12;
            this.txtDireccionIp.Text = "hola";
            // 
            // lblMinimizar2
            // 
            this.lblMinimizar2.AutoSize = true;
            this.lblMinimizar2.Location = new System.Drawing.Point(341, 12);
            this.lblMinimizar2.Name = "lblMinimizar2";
            this.lblMinimizar2.Size = new System.Drawing.Size(13, 13);
            this.lblMinimizar2.TabIndex = 11;
            this.lblMinimizar2.Text = "  ";
            this.lblMinimizar2.Click += new System.EventHandler(this.lblMinimizar2_Click);
            // 
            // lblCerrar2
            // 
            this.lblCerrar2.AutoSize = true;
            this.lblCerrar2.Location = new System.Drawing.Point(367, 12);
            this.lblCerrar2.Name = "lblCerrar2";
            this.lblCerrar2.Size = new System.Drawing.Size(13, 13);
            this.lblCerrar2.TabIndex = 10;
            this.lblCerrar2.Text = "  ";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(161, 187);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(85, 24);
            this.lblGuardar.TabIndex = 9;
            this.lblGuardar.Text = "Guardar";
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            // 
            // lblCerrarConfiguracion
            // 
            this.lblCerrarConfiguracion.AutoSize = true;
            this.lblCerrarConfiguracion.Location = new System.Drawing.Point(296, 12);
            this.lblCerrarConfiguracion.Name = "lblCerrarConfiguracion";
            this.lblCerrarConfiguracion.Size = new System.Drawing.Size(25, 13);
            this.lblCerrarConfiguracion.TabIndex = 8;
            this.lblCerrarConfiguracion.Text = "      ";
            this.lblCerrarConfiguracion.Click += new System.EventHandler(this.lblCerrarConfiguracion_Click);
            // 
            // pnlIntentandoConexion
            // 
            this.pnlIntentandoConexion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlIntentandoConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIntentandoConexion.BackgroundImage")));
            this.pnlIntentandoConexion.Controls.Add(this.lblIntentandoConectar);
            this.pnlIntentandoConexion.Location = new System.Drawing.Point(674, 423);
            this.pnlIntentandoConexion.Name = "pnlIntentandoConexion";
            this.pnlIntentandoConexion.Size = new System.Drawing.Size(379, 226);
            this.pnlIntentandoConexion.TabIndex = 2;
            this.pnlIntentandoConexion.Visible = false;
            // 
            // lblIntentandoConectar
            // 
            this.lblIntentandoConectar.AutoSize = true;
            this.lblIntentandoConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentandoConectar.ForeColor = System.Drawing.Color.White;
            this.lblIntentandoConectar.Location = new System.Drawing.Point(98, 87);
            this.lblIntentandoConectar.Name = "lblIntentandoConectar";
            this.lblIntentandoConectar.Size = new System.Drawing.Size(179, 72);
            this.lblIntentandoConectar.TabIndex = 0;
            this.lblIntentandoConectar.Text = "Intentando Conectar\r\n\r\nEspere...\r\n";
            // 
            // tmProcesos
            // 
            this.tmProcesos.Interval = 1000;
            this.tmProcesos.Tick += new System.EventHandler(this.tmProcesos_Tick);
            // 
            // tmNavegadorVisible
            // 
            this.tmNavegadorVisible.Tick += new System.EventHandler(this.tmNavegadorVisible_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 253);
            this.Controls.Add(this.pnlIntentandoConexion);
            this.Controls.Add(this.pnlConfiguracion);
            this.Controls.Add(this.pnlConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnlConectar.ResumeLayout(false);
            this.pnlConectar.PerformLayout();
            this.pnlConfiguracion.ResumeLayout(false);
            this.pnlConfiguracion.PerformLayout();
            this.pnlIntentandoConexion.ResumeLayout(false);
            this.pnlIntentandoConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConectar;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblDireccionIP;
        private System.Windows.Forms.Label lblConectar;
        private System.Windows.Forms.Panel pnlConfiguracion;
        private System.Windows.Forms.Label lblCerrarConfiguracion;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblAbrirConfigurar;
        private System.Windows.Forms.Label lblMinimizar1;
        private System.Windows.Forms.Label lblCerrar1;
        private System.Windows.Forms.Label lblMinimizar2;
        private System.Windows.Forms.Label lblCerrar2;
        private System.Windows.Forms.Panel pnlIntentandoConexion;
        private System.Windows.Forms.Label lblIntentandoConectar;
        private System.Windows.Forms.Timer tmProcesos;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtDireccionIp;
        private System.Windows.Forms.Timer tmNavegadorVisible;
    }
}

