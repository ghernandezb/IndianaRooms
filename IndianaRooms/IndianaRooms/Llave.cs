using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Llave : IAccionable
    {
        public string Accionar()
        {
            return "Llave recuperada";
        }
    }
}
