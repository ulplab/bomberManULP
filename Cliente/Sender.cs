using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Sender
    {
        StreamReader reader;
        StreamWriter writer;
        int port;
        String ip;
        TcpClient client;

        public Sender(int port, String ip)
        {
            this.port = port;
            this.ip = ip;
        }
        public void escribir()
        {

        }
        
    }
}
