namespace StreamingClient
{
    partial class Capturas
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
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.pbCapturas = new System.Windows.Forms.PictureBox();
            this.tmCaptura = new System.Windows.Forms.Timer(this.components);
            this.tmControlConexion = new System.Windows.Forms.Timer(this.components);
            this.pnlCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCaptura
            // 
            this.pnlCaptura.BackColor = System.Drawing.Color.White;
            this.pnlCaptura.Controls.Add(this.pbCapturas);
            this.pnlCaptura.Location = new System.Drawing.Point(22, 21);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(1199, 617);
            this.pnlCaptura.TabIndex = 0;
            // 
            // pbCapturas
            // 
            this.pbCapturas.BackColor = System.Drawing.Color.White;
            this.pbCapturas.Location = new System.Drawing.Point(0, 0);
            this.pbCapturas.Name = "pbCapturas";
            this.pbCapturas.Size = new System.Drawing.Size(859, 505);
            this.pbCapturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapturas.TabIndex = 0;
            this.pbCapturas.TabStop = false;
            // 
            // tmCaptura
            // 
            this.tmCaptura.Tick += new System.EventHandler(this.tmCaptura_Tick);
            // 
            // tmControlConexion
            // 
            this.tmControlConexion.Interval = 2500;
            this.tmControlConexion.Tick += new System.EventHandler(this.tmControlConexion_Tick);
            // 
            // Capturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 534);
            this.Controls.Add(this.pnlCaptura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Capturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Capturas_Load);
            this.pnlCaptura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.PictureBox pbCapturas;
        private System.Windows.Forms.Timer tmCaptura;
        private System.Windows.Forms.Timer tmControlConexion;
    }
}