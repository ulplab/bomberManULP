using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
//using Newtonsoft.Json;

namespace Entidades
{
    class Player
    {
        TcpClient tcpCliente;
        ePlayer nombre;
        int posX;
        int posY;
        eEstadoPlayer estado;
        eTipoBomba bomba;

        public Player(ePlayer nombre)
        {
            this.nombre = nombre;
            bomba = eTipoBomba.Bomba1;
        }

        public Player(ePlayer nombre, TcpClient tcpCliente)
        {
            this.nombre = nombre;
            this.tcpCliente = tcpCliente;
            bomba = eTipoBomba.Bomba1;
        }

        public TcpClient TcpCliente
        {
            get { return tcpCliente; }
            set { tcpCliente = value; }
        }

        public ePlayer Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public eEstadoPlayer Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public eTipoBomba Bomba
        {
            get { return bomba; }
            set { bomba = value; }
        }
    }
}
