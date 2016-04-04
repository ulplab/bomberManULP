using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum eTipoMensaje { Movimiento, Bomba };
    public enum eOwn {Player1, Player2, Player3, Player4, Servidor};
    public enum ePlayer { Player1, Player2, Player3, Player4};
    public enum eNivel { Level1, Level2, Level3};

    interface iMensaje
    {
        eOwn Owner { get; set; }
        eTipoMensaje Tipo { get;}
        eNivel Nivel { get; set; }
    }
}
