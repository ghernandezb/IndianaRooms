using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaRooms
{
    class CuartoLlave : Cuarto
    {
        public CuartoLlave(Coordenada coord) : base(coord)
        {
            InsertarObjetoACuadrante(new PuertaLlave(), true);
            InsertarObjetoACuadrante(new Llave(), false);
        }
    }
}
