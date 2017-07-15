using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Acertijo : IAccionable
    {
        public string Texto { get; private set; }

        public Acertijo(string texto)
        {
            Texto = texto;
        }

        public string Accionar()
        {
            return Texto;
        }
    }
}
