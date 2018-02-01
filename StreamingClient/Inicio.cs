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
    public partial class Inicio : Form
    {
        
        public static bool navegador_visible = false;
        DatosConexion datosConexion = new DatosConexion();
        Funciones funciones = new Funciones();
        Navegador navegador;
        Size tamañoGeneral = new Size(389, 219);
        int contador_espera_conexion = 0;
        private string Ok="000";
        string no_configurado = "No Configurado";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Inicio()
        {
            InitializeComponent();
        }
        public void mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void cargar()
        {
            #region inicializando
                this.Size = tamañoGeneral;
                Size size= System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
                this.Location = new Point(((size.Width)/2)-(this.Width)/2,((size.Height)/2)-(this.Height)/2);
                pnlConectar.Location = new Point(0,0);
                pnlConectar.Size=tamañoGeneral;
                lblAbrirConfigurar.Parent = pnlConectar;
                lblAbrirConfigurar.BackColor = Color.Transparent;
                lblCerrar1.Parent = pnlConectar;
                lblCerrar1.BackColor = Color.Transparent;
                lblMinimizar1.Parent = pnlConectar;
                lblMinimizar1.BackColor = Color.Transparent;
                lblDireccionIP.Parent = pnlConectar;
                lblDireccionIP.BackColor = Color.Transparent;
                lblPuerto.Parent = pnlConectar;
                lblPuerto.BackColor = Color.Transparent;
                lblUrl.Parent = pnlConectar;
                lblUrl.BackColor = Color.Transparent;
                lblConectar.Parent = pnlConectar;
                lblConectar.BackColor = Color.Transparent;
                pnlConfiguracion.Location = new Point(0,0);
                pnlConfiguracion.Visible = false;
                lblCerrarConfiguracion.Parent = pnlConfiguracion;
                lblCerrarConfiguracion.BackColor = Color.Transparent;
                lblCerrarConfiguracion.Location = new Point(296, 12);
                lblGuardar.Parent = pnlConfiguracion;
                lblGuardar.BackColor = Color.Transparent;
                lblMinimizar2.Parent = pnlConfiguracion;
                lblMinimizar2.BackColor = Color.Transparent;
                lblCerrar2.Parent = pnlConfiguracion;
                lblCerrar2.BackColor = Color.Transparent;
                lblIntentandoConectar.BackColor = Color.Transparent;
                lblIntentandoConectar.Parent = pnlIntentandoConexion;
                pnlIntentandoConexion.Location = new Point(0, 0);
                txtDireccionIp.BackColor =  Color.FromArgb(167, 2, 58);
                txtPuerto.BackColor=Color.FromArgb(167, 2, 58);
                txtUrl.BackColor = Color.FromArgb(167, 2, 58);
                tmNavegadorVisible.Enabled = true;
                navegador_visible = false;
                limpiar_cajas();
                intentar_conexion();
            #endregion
        }


        public void intentar_conexion()
        {
            tmProcesos.Enabled = true;
            pnlIntentandoConexion.Visible = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            carga_datos_conexion();
            EsperaConexion esperaConexion = new EsperaConexion(datosConexion);
            EsperaConexion.puede_esperar_conexion = false;
            esperaConexion.Show();
            navegador = new Navegador(datosConexion);
            navegador.Show();
            navegador.Visible = false;
            cargar();
        }


        public void carga_datos_conexion()
        {
            datosConexion = funciones.desatar(funciones.recupera_datos_conexion());
            if(datosConexion!=null)
            {
                lblDireccionIP.Text = datosConexion.DireccionIp;
                lblPuerto.Text = datosConexion.Puerto.ToString();
                lblUrl.Text = datosConexion.Url;
            }
            else
            {
                lblDireccionIP.Text = no_configurado;
                lblPuerto.Text = no_configurado;
                lblUrl.Text = no_configurado;
            }
        }

        public string procesa_conexion()
        {
            string retorno = string.Empty;
            string trama = funciones.recupera_datos_conexion();
            if(trama.Length>0 && !trama.Contains("Error"))
            {
                datosConexion = funciones.desatar(trama);
                if (funciones.verifica_conexion(datosConexion)) 
                {
                    //lanzar capturas
                    retorno = Ok;
                }
                else
                {
                    //mostrar que no se pudo conetar
                    retorno = "No se ha podido establecer comunicacion con el servidor";
                }
            }
            else
            {
                retorno = trama;
                
            }
            return retorno;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Esta segudo de cerrar la aplicación","Aviso!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation))
            {
                this.Close();
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblDireccionIP_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void lblPuerto_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void lblUrl_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void lblDireccionIP_Click(object sender, EventArgs e)
        {
            
        }

        private void lblConfigurar_Click(object sender, EventArgs e)
        {
            pnlConfiguracion.Visible = true;
        }

        private void lblCerrarConfiguracion_Click(object sender, EventArgs e)
        {
            pnlConfiguracion.Visible = false;
        }

        private void pnlConfiguracion_MouseDown(object sender, MouseEventArgs e)
        {
            mover();
        }

        private void lblMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmProcesos_Tick(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            if(contador_espera_conexion>1)
            {
                contador_espera_conexion = 0;
                retorno = procesa_conexion();
                if (retorno == Ok)
                {
                    Capturas capturas = new Capturas(funciones.desatar(funciones.recupera_datos_conexion()));
                    capturas.Show();
                    this.Visible = false;
                }
                else
                {
                    //Mensaje mensaje = new Mensaje(retorno,false,null);
                    if (!funciones.ping(datosConexion))
                    {
                        Mensaje mensaje = new Mensaje(retorno, false, null);
                        mensaje.Show();
                    }
                    else
                    {
                        EsperaConexion.puede_esperar_conexion = true;
                        navegador_visible = true;
                        //Mensaje mensaje = new Mensaje(retorno, true, datosConexion);
                        //mensaje.Show();
                        carga_datos_conexion();
                    }
                }
                tmProcesos.Enabled = false;
                pnlIntentandoConexion.Visible = false;
            }
            else
            {
                contador_espera_conexion++;
            }
        }

        public void limpiar_cajas()
        {
            txtDireccionIp.Text = "";
            txtPuerto.Text = "";
            txtUrl.Text = "";
        }
        private void lblGuardar_Click(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            retorno = funciones.verifica_datos_conexion(txtDireccionIp.Text, txtPuerto.Text, txtUrl.Text);
            if (retorno == Ok)
            {
                retorno = funciones.guarda_datos_conexion(txtDireccionIp.Text + "*" + txtPuerto.Text + "*" + txtUrl.Text);
                Mensaje mensaje = new Mensaje(retorno, false, null);
                mensaje.Show();
                if (!retorno.Contains("Error"))
                {
                    limpiar_cajas();
                    carga_datos_conexion();
                }
            }
            else
            {
                Mensaje mensaje = new Mensaje(retorno, false, null);
                mensaje.Show();
            }
        }

        private void lblConectar_Click(object sender, EventArgs e)
        {
            intentar_conexion();
        }

        private void tmNavegadorVisible_Tick(object sender, EventArgs e)
        {
            if(navegador_visible)
            {
                navegador.Visible = true;
            }
            else
            {
                navegador.Visible = false;
            }
        }

       
    }
}
