using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Llave : Accionable
    {
        public Llave() : base ("Llave")
        {

        }

        public override bool Accionar(Jugador jugador, out string mensaje)
        {
            jugador.AgregarInventario(this);
            jugador.Cuarto.RemoverObjetoDeCuadrante(jugador.Posicion);
            mensaje = "Llave recuperada";
            return true;
        }
    }
}
