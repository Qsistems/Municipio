using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace StreamingClient
{
    public class Funciones
    {
        private string Ok;
        private string pedirImg;
        private int tamañoBuffer;

        public Funciones()
        {
            Ok="000";
            pedirImg = "001";
            tamañoBuffer=Convert.ToInt32(ConfigurationManager.AppSettings["tamaño_buffer"].ToString());
        }

        //Método que recupera los datos de conexion, los retorna en una trama con los datos concatenados por '*'
        public string recupera_datos_conexion()
        {
            string retorno = string.Empty;
            try
            {
                using (System.IO.StreamReader lector = new System.IO.StreamReader("DatosConexion.txt"))
                {
                    string datos = lector.ReadLine();
                    retorno = datos;
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                retorno = "Error: No se pudo obtener archivo de configuración";
            }
            return retorno;
        }

        //Mñetodo que guarda los datos de conexion se debe pasar una trmadel tipo: direccionIp*puerto*url
        public string guarda_datos_conexion(string trama)
        {
            string retorno = string.Empty;
            try
            {
                using (System.IO.StreamWriter escritor = new System.IO.StreamWriter("DatosConexion.txt"))
                {
                    if (trama.Length > 0)
                    {
                        escritor.WriteLine(trama);
                        escritor.Close();
                        retorno = "Se ha guardado la configuración correctamente";
                    }
                    else
                    {
                        retorno = "Datos Incompletos!";
                    }
                }
            }
            catch (Exception ex)
            {
                retorno = "Error: No se pudo guardar la configuracion";
            }
            return retorno;
        }

        //Método que retorna una trama con todos los datos concatenados: direccionIp*puerto*url
        public string empacar(DatosConexion datosConexion)
        {
            return datosConexion.DireccionIp + "*" + datosConexion.Puerto + "*" + datosConexion.Url;
        }

        //Mñetodo que retorna los datos de conexion embebeidos en una clase
        public DatosConexion desatar(string trama)
        {
            DatosConexion datosConexion = new DatosConexion();
            if (trama.Length > 0 && !trama.Contains("Error"))
            {
                string[] datos = trama.Split('*');
                datosConexion.DireccionIp = datos[0].ToString();
                datosConexion.Puerto = Convert.ToInt32(datos[1].ToString());
                datosConexion.Url = datos[2].ToString();
            }
            else
            {
                datosConexion = null;
            }
            return datosConexion;
        }

        //Métoodo que retorna verdadero solo si se pudo establecer una comunicacion con el servidor
        public bool verifica_conexion(DatosConexion datosConexion)
        {
            bool indicador = false;
            

            try
            {
                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(datosConexion.DireccionIp), datosConexion.Puerto);
                Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Verifica conexion
                miPrimerSocket.Connect(direccion);
                byte[] bytes = Encoding.ASCII.GetBytes(Ok);
                byte[] byte1 = new byte[tamañoBuffer];
                miPrimerSocket.SendTo(bytes, SocketFlags.None, direccion);
                miPrimerSocket.Shutdown(SocketShutdown.Send);
                int dato = miPrimerSocket.Receive(byte1);
                string retorno = Encoding.ASCII.GetString(byte1);
                string respuesta = "";
                for (int i = 0; i < retorno.Length; i++)
                {
                    if (retorno.Substring(i, 1) != "\0")
                        respuesta += retorno.Substring(i, 1);
                }
                miPrimerSocket.Close();
                if (respuesta == "000")
                {
                    indicador = true;
                }

                //Pide imagen
                if(indicador)
                {
                    string ret=envia_recibe_datos(datosConexion);
                    if (ret != null)
                    {
                        if (ret.Length > 100)
                        {
                            indicador = true;
                        }
                        else
                        {
                            indicador = false;
                        }
                    }
                    else
                    {
                        indicador = false;
                    }
                }
            }
            catch (Exception ex)
            {
                indicador = false;
            }
            return indicador;
        }


        public bool ping(DatosConexion datosConexion)
        {
            bool indicador = false;


            try
            {
                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(datosConexion.DireccionIp), datosConexion.Puerto);
                Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Verifica conexion
                miPrimerSocket.Connect(direccion);
                byte[] bytes = Encoding.ASCII.GetBytes(Ok);
                byte[] byte1 = new byte[tamañoBuffer];
                miPrimerSocket.SendTo(bytes, SocketFlags.None, direccion);
                miPrimerSocket.Shutdown(SocketShutdown.Send);
                int dato = miPrimerSocket.Receive(byte1);
                string retorno = Encoding.ASCII.GetString(byte1);
                string respuesta = "";
                for (int i = 0; i < retorno.Length; i++)
                {
                    if (retorno.Substring(i, 1) != "\0")
                        respuesta += retorno.Substring(i, 1);
                }
                miPrimerSocket.Close();
                if (respuesta == "000")
                {
                    indicador = true;
                }
                else
                {
                    indicador = false;
                }

            }
            catch (Exception ex)
            {
                indicador = false;
            }
            return indicador;
        }
        
        /* 
        public bool verifica_conexion(DatosConexion datosConexion)
        {
            bool indicador = false;
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(datosConexion.DireccionIp), datosConexion.Puerto);
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                miPrimerSocket.Connect(direccion);
                byte[] bytes = Encoding.ASCII.GetBytes(Ok);
                byte[] byte1 = new byte[tamañoBuffer];
                miPrimerSocket.SendTo(bytes, SocketFlags.None, direccion);
                miPrimerSocket.Shutdown(SocketShutdown.Send);
                int dato = miPrimerSocket.Receive(byte1);
                string retorno = Encoding.ASCII.GetString(byte1);
                string respuesta = "";
                for (int i = 0; i < retorno.Length; i++)
                {
                    if (retorno.Substring(i, 1) != "\0")
                        respuesta += retorno.Substring(i, 1);
                }
                miPrimerSocket.Close();
                if (respuesta == "000")
                {
                    indicador = true;
                }
            }
            catch (Exception ex)
            {
                indicador = false;
            }
            return indicador;
        }*/

        //Método que procesa el envio y recepción de paquetes al servidor
        public string envia_recibe_datos(DatosConexion datosConexion)
        {
            string retorno = string.Empty;
           

            try
            {
                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(datosConexion.DireccionIp), datosConexion.Puerto);
                Socket Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Sock.Connect(direccion);
                NetworkStream nst = new NetworkStream(Sock);
                StreamReader str = new StreamReader(nst);
                StreamWriter stw = new StreamWriter(nst);
                byte[] bytes = Encoding.ASCII.GetBytes(pedirImg);
                byte[] byte1 = new byte[tamañoBuffer];
                Sock.SendTo(bytes, SocketFlags.None, direccion);
                Sock.Shutdown(SocketShutdown.Send);

                stw.Flush();
                retorno = str.ReadLine();
                Sock.Close();
            }
            catch (Exception ex)
            {
                retorno = "Error: No se pudo obtener respuesta del servidor";
            }
            return retorno;
        }

        //Metodo que valida una Direccion IP
        public string verifica_datos_conexion(string direccionIp,string puerto,string url)
        {
            string retorno = string.Empty;
            try
            {
                IPAddress ip = IPAddress.Parse(direccionIp);
            }
            catch
            {
                retorno = "Error: Direccion Ip Invalida";
                return retorno;
            }
            
            for(int i=0;i<puerto.Length;i++)
            {
                if(!char.IsNumber(Convert.ToChar(puerto.Substring(i,1))))
                {
                    retorno = "Error: Puerto contiene caracteres invalidos";
                    return retorno;
                }
                if(i>4)
                {
                    retorno = "Error: Puerto invalido";
                    return retorno;
                }
            }


            
            if(url.Length>1)
            {
                for (int i = 0; i < url.Length;i++)
                {
                    if(url.Substring(i,1)==" ")
                    {
                        retorno = "Error: la Url contiene espacios";
                        return retorno;
                    }
                }
            }
            else
            {
                retorno = "Error: la Url debe contender caracteres";
                return retorno;
            }
            return Ok;
        }

        public Image base64_a_imagen(string trama)
        {
            byte[] bytes = Convert.FromBase64String(trama);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        

    }
}
