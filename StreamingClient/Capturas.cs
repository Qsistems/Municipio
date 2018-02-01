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
using System.Configuration;

namespace StreamingClient
{
    public partial class Capturas : Form
    {
        public static bool estado_conexion = false;   
        private int intervalo_timer;
        Funciones funciones = new Funciones();
        DatosConexion datosConexion;
        private int contador_conexion_perdida = 0;

        public Capturas(DatosConexion datos_conexion)
        {
            InitializeComponent();
            intervalo_timer =Convert.ToInt32(ConfigurationManager.AppSettings["intervalo_timer"].ToString());
            tmCaptura.Interval = intervalo_timer;
            datosConexion = datos_conexion;
        }

        public void carcar()
        {
            pnlCaptura.Size = this.Size;
            pnlCaptura.Location = new Point(0,0);
            pbCapturas.Location = new Point(0,0);
            this.Size = pbCapturas.Size;
            tmCaptura.Enabled = true;
            pbCapturas.BackColor = Color.White;
            this.BackColor = Color.White;
            pnlCaptura.BackColor = Color.White; 
            tmControlConexion.Enabled = true;
        }

        private void Capturas_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            carcar();
        }

        private void tmCaptura_Tick(object sender, EventArgs e)
        {
            string retorno = funciones.envia_recibe_datos(datosConexion);
            if (retorno != null)
            {
                if (!retorno.Contains("Error") && retorno.Length>100)
                {
                    pbCapturas.Image = funciones.base64_a_imagen(retorno);
                    contador_conexion_perdida = 0;
                    estado_conexion = true;
                    pbCapturas.Size = this.Size;
                }
                else
                {
                    
                    contador_conexion_perdida++;
                    if(contador_conexion_perdida>50)
                    {
                        pbCapturas.BackColor = Color.White;
                    }
                }
            }
            else
            {
                contador_conexion_perdida++;
                if (contador_conexion_perdida > 50)
                {
                    pbCapturas.BackColor = Color.White;
                }
            }
        }

       
        private void tmControlConexion_Tick(object sender, EventArgs e)
        {
            if(!estado_conexion)
            {
                tmCaptura.Enabled = false;
                tmControlConexion.Enabled = false;
                EsperaConexion.puede_esperar_conexion = true;
                Inicio.navegador_visible = true;
                this.Visible = false;
            }
            else
            {
                estado_conexion = false;
            }
        }

        
    }
}
