using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace AfficheurV1
{
    public static class Ethernet_Send
    {
        private static byte[] bytes;
        private static NetworkStream netStream;

        public static string Ethernet_Envoi(string Message)
        {

            try
            {
                MessageSend(MainForm.PortsIP, MainForm.AddressIP, Message);
                return "OK";
            } catch
            {
                return "Ethernet Error !";
            }
        }

        private static void MessageSend(String PortsIP, string AddressIP, String Command)
        {
            TcpClient tcpClient = new TcpClient(AddressIP, Int32.Parse(PortsIP));
            netStream = tcpClient.GetStream();

            Byte[] sendBytes = Encoding.UTF8.GetBytes(Command);
            netStream.Write(sendBytes, 0, sendBytes.Length);
            bytes = new byte[10000];
            System.Threading.Thread.Sleep(2000);
            netStream.Read(bytes, 0, 10000);

            tcpClient.GetStream().Close();
            tcpClient.Close();
        }
    }
}
