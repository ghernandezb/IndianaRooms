using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Acertijo : Accionable
    {
        public string Texto { get; private set; }

        public Acertijo(string texto) : base("Acertijo")
        {
            Texto = texto;
        }

        public override bool Accionar(Jugador jugador, out string message)
        {
            message = Texto;
            return true;
        }
    }
}
