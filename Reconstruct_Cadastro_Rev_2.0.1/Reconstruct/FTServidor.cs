using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconstruct
{
    class FTServidor
    {
            public static string mensagemServidor = "Serviço Iniciado";
            

            public static void IniciarServidor()
            {
                try
                {
                
               
                //Colocar ip da rede
                System.Net.IPAddress localadrr = System.Net.IPAddress.Parse("192.168.1.5");

                    TcpListener escutar = new TcpListener(localadrr, 12345);

                    escutar.Start();
                
                    Socket soc = escutar.AcceptSocket();
                    
                    if (soc.Connected)
                    {
                        mensagemServidor += " \n Conectado com o cliente.";
                    // Para mandar JSON
                        string Filename = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString())+"UVA.JSON";

                    //  Tentativa de enviar um arquivo
                    //string Filename = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "ProMEDCT0051.obj";


                    //soc.BeginSendFile(Filename, new AsyncCallback(FileSendCallback), soc);
                    soc.BeginSendFile(Filename, delegate(IAsyncResult ar) {
                            Socket client = (Socket)ar.AsyncState;
                            // Complete sending the data to the remote device.
                            client.EndSendFile(ar);

                            escutar.Stop();

                        }, soc);




                    }
                } catch (Exception ex)
                {
                    mensagemServidor += "Não foi possivel estabelecer conexão." + "\n" + ex.Message;

                } 


            }

        private static void FileSendCallback(IAsyncResult ar)
        {
            // Retrieve the socket from the state object.
            Socket client = (Socket)ar.AsyncState;
            // Complete sending the data to the remote device.
            
            client.EndSendFile(ar);
            
            //sendDone.Set();

          
        }



    }
}
