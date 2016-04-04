using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Listener
    {
        StreamReader reader;
        StreamWriter writer;
        int port;
        String ip;
        TcpClient client;

        public Listener(int port, String ip)
        {
            this.port = port;
            this.ip = ip;
        }

        public void escuchar()
        {
            client = new TcpClient(ip, port);
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };

            while (client.Connected)
            {
                string lineReceived = reader.ReadLine();
                Console.WriteLine("El servidor respondio: " + lineReceived);
                /*TIRAR EVENTO*/
            }
            writer.Close();
            reader.Close();
            stream.Close();
            client.Close();
        }
    }
}
