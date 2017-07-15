using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Genero : IAccionable
    {
        public bool Masculino { get; private set; }

        public Genero(bool masculino)
        {
            Masculino = masculino;
        }

        public string Accionar()
        {
            return "Soy " + (Masculino ? "Hombre" : "Mujer");
        }
    }
}
