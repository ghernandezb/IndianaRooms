using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaRooms.Interfaces
{
    abstract class Accionable
    {
        private string Etiqueta{ get; set; }

        public Accionable(string etiqueta)
        {
            Etiqueta = etiqueta;
        }

        public abstract bool Accionar(Jugador jugador1, out string mensaje);

        public string GetEtiqueta()
        {
            return Etiqueta;
        }
    }
}
