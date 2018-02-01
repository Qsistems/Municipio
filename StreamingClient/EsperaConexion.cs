using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingClient
{
    public partial class EsperaConexion : Form
    {
        Funciones funciones = new Funciones();
        DatosConexion datosConexion;
        public static bool puede_esperar_conexion=false;
        public EsperaConexion(DatosConexion datos_conexion)
        {
            InitializeComponent();
            datosConexion = datos_conexion;
        }

        private void tmEsperaConexin_Tick(object sender, EventArgs e)
        {
            if (funciones.verifica_conexion(datosConexion))
            {
                string retorno = string.Empty;
                retorno = funciones.envia_recibe_datos(datosConexion);
                if (retorno != null)
                {
                    if (retorno.Length > 100 && puede_esperar_conexion)
                    {
                        Capturas capturas = new Capturas(datosConexion);
                        Capturas.estado_conexion = true;
                        capturas.Show();
                        puede_esperar_conexion = false;
                        Inicio.navegador_visible = false;

                    }
                }
            }

        }

        private void EsperaConexion_Load(object sender, EventArgs e)
        {

        }
    }
}
