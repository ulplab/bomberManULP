using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MensajeBomba : iMensaje
    {
        eOwn owner;
        eTipoMensaje tipo;

        eTipoBomba bomba;
        int posX;
        int posY;

        public MensajeBomba(eOwn owner, eTipoBomba bomba, int posX, int posY)
        {
            tipo = eTipoMensaje.Bomba;
            this.owner = owner;
            this.bomba = bomba;
            this.posX = posX;
            this.posY = posY;
        }

        public eTipoBomba Bomba
        {
            get { return bomba; }
            set { bomba = value; }
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
