using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class MensajeMover : iMensaje
    {
        eOwn owner;
        eTipoMensaje tipo;

        ePlayer objetivo;
        int posX;
        int posY;

        public MensajeMover(eOwn owner, ePlayer objetivo, int posX, int posY)
        {
            tipo = eTipoMensaje.Movimiento;
            this.owner = owner;
            this.objetivo = objetivo;
            this.posX = posX;
            this.posY = posY;
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public ePlayer Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }

        public eTipoMensaje Tipo
        {
            get { return tipo; }
        }

        public eOwn Owner
        {
            get { return owner; }
            set { owner = value; }
        }
    }
}
