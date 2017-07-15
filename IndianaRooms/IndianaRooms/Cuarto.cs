using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaRooms
{
    class Cuarto
    {
        public bool Abierto { get; private set; }
        public object[,] Cuadrantes { get; private set; }

        public Cuarto(Coordenada coord) {
            Cuadrantes = new object[coord.X, coord.Y];
        }

        public void AbrirCuarto()
        {
            Abierto = true;
        }

        public object ObtenerObjetoDeCuadrante(Coordenada coor)
        {
            return  Cuadrantes[coor.X, coor.Y];
        }

        public void RemoverObjetoDeCuadrante(Coordenada coor)
        {
            Cuadrantes[coor.X, coor.Y] = null;
        }
    }
}
