using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingClient
{
    public partial class Navegador : Form
    {
        Funciones funciones = new Funciones();
        DatosConexion datosConexion;
        //Size tamañoGeneral = new Size(756, 454);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void cargar()
        {
            this.WindowState = FormWindowState.Maximized;
            Size size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            wbNavegador.Location = new Point(0, 0);
            tmProcesos.Enabled = true;
            tmEsperaConexin.Enabled = true;
        }

        public Navegador(DatosConexion datos_conexion)
        {
            InitializeComponent();
            datosConexion = datos_conexion;
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            cargar();
            try{wbNavegador.Navigate(datosConexion.Url);}catch{}
        }

        private void Navegador_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void pnlNavegador_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

     
        private void tmProcesos_Tick(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal || this.WindowState==FormWindowState.Maximized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }


        private void tmRedimencionarWeb_Tick(object sender, EventArgs e)
        {
            wbNavegador.Width = this.Width;
            wbNavegador.Height = this.Height;
            wbNavegador.Location = new Point(0, 0);
        }

        private void tmEsperaConexin_Tick(object sender, EventArgs e)
        {

        }

      

       

    }
}
