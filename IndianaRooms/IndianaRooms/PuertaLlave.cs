using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class PuertaLlave : IAccionable
    {
        public bool Abierta { get; private set; }

        public string Accionar()
        {
            if (Abierta)
            {

            }

            return "Pasando al siguiente cuarto...";
        }
    }
}
