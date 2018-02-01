namespace StreamingClient
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.lblAceptar = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtFoco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptar.ForeColor = System.Drawing.Color.White;
            this.lblAceptar.Location = new System.Drawing.Point(159, 192);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(82, 24);
            this.lblAceptar.TabIndex = 7;
            this.lblAceptar.Text = "Aceptar";
            this.lblAceptar.Click += new System.EventHandler(this.lblAceptar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.Brown;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.White;
            this.txtMensaje.Location = new System.Drawing.Point(57, 56);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(282, 100);
            this.txtMensaje.TabIndex = 9;
            this.txtMensaje.Text = "Este es un mensaje de Qmatic";
            // 
            // txtFoco
            // 
            this.txtFoco.BackColor = System.Drawing.Color.Brown;
            this.txtFoco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoco.ForeColor = System.Drawing.Color.White;
            this.txtFoco.Location = new System.Drawing.Point(441, 211);
            this.txtFoco.Multiline = true;
            this.txtFoco.Name = "txtFoco";
            this.txtFoco.ReadOnly = true;
            this.txtFoco.Size = new System.Drawing.Size(26, 15);
            this.txtFoco.TabIndex = 10;
            this.txtFoco.Text = "Este es un mensaje de Qmatic";
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 257);
            this.Controls.Add(this.txtFoco);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Mensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAceptar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtFoco;
    }
}