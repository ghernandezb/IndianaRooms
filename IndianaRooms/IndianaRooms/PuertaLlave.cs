using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class PuertaLlave : Accionable
    {
        public PuertaLlave() : base("Puerta")
        {

        }

        public override bool Accionar(Jugador jugador, out string mensaje)
        {
            if (jugador.BuscarItem(typeof(Llave)) != null)
            {
                mensaje = "Has pasado de nivel";
                jugador.RemoverInventario(typeof(Llave));
                return true;
            }
            else
            {
                mensaje = "La puerta esta cerrada con llave, busca la llave.";
                return false;
            }
        }
    }
}
