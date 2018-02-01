namespace StreamingClient
{
    partial class Navegador
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
            this.wbNavegador = new System.Windows.Forms.WebBrowser();
            this.tmProcesos = new System.Windows.Forms.Timer(this.components);
            this.tmEsperaConexin = new System.Windows.Forms.Timer(this.components);
            this.tmRedimencionarWeb = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // wbNavegador
            // 
            this.wbNavegador.Location = new System.Drawing.Point(51, 12);
            this.wbNavegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegador.Name = "wbNavegador";
            this.wbNavegador.ScriptErrorsSuppressed = true;
            this.wbNavegador.Size = new System.Drawing.Size(721, 393);
            this.wbNavegador.TabIndex = 0;
            // 
            // tmProcesos
            // 
            this.tmProcesos.Enabled = true;
            this.tmProcesos.Interval = 50;
            this.tmProcesos.Tick += new System.EventHandler(this.tmProcesos_Tick);
            // 
            // tmEsperaConexin
            // 
            this.tmEsperaConexin.Enabled = true;
            this.tmEsperaConexin.Interval = 1000;
            this.tmEsperaConexin.Tick += new System.EventHandler(this.tmEsperaConexin_Tick);
            // 
            // tmRedimencionarWeb
            // 
            this.tmRedimencionarWeb.Enabled = true;
            this.tmRedimencionarWeb.Interval = 50;
            this.tmRedimencionarWeb.Tick += new System.EventHandler(this.tmRedimencionarWeb_Tick);
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 580);
            this.ControlBox = false;
            this.Controls.Add(this.wbNavegador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Navegador";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Navegador_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navegador_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbNavegador;
        private System.Windows.Forms.Timer tmProcesos;
        private System.Windows.Forms.Timer tmEsperaConexin;
        private System.Windows.Forms.Timer tmRedimencionarWeb;
    }
}