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
    public partial class Mensaje : Form
    {
        string DatoMensaje = string.Empty;
        Size tamañoGeneral = new Size(393, 239);
        Color colorFondo = Color.FromArgb(167, 2, 58);
        bool CargarNavegador = false;
        DatosConexion datosConexion;
        public Mensaje(string mensaje,bool cargar_navegador,DatosConexion datos_conexion)
        {
            InitializeComponent();
            DatoMensaje = mensaje;
            CargarNavegador = cargar_navegador;
            datosConexion = datos_conexion;
        }


        public void cargar()
        {
            lblAceptar.Parent = this;
            lblAceptar.BackColor = Color.Transparent;
            txtMensaje.Text = DatoMensaje+" ";
            txtMensaje.BackColor = colorFondo;
            txtMensaje.ForeColor = Color.White;
            this.Size = tamañoGeneral;
            Size size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            this.Location = new Point(((size.Width) / 2) - (this.Width) / 2, ((size.Height) / 2) - (this.Height) / 2);
            this.StartPosition = FormStartPosition.CenterParent;
            txtMensaje.SelectionStart = txtMensaje.Text.Length;
            txtMensaje.SelectionLength = txtMensaje.Text.Length;
            this.ActiveControl = txtFoco;
        }
        private void Mensaje_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void lblAceptar_Click(object sender, EventArgs e)
        {
            if(CargarNavegador)
            {
                Inicio.navegador_visible = true;
            }
            this.Hide();
        }
    }
}
