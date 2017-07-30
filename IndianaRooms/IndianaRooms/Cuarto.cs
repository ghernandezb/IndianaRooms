using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Cuarto
    {
        public IAccionable [,] Cuadrantes { get; private set; }

        public Cuarto(Coordenada coord) {
            Cuadrantes = new IAccionable[coord.X, coord.Y];
        }

        public object ObtenerObjetoDeCuadrante(Coordenada coor)
        {
            return  Cuadrantes[coor.X, coor.Y];
        }

        public void RemoverObjetoDeCuadrante(Coordenada coor)
        {
            Cuadrantes[coor.X, coor.Y] = null;
        }
        public virtual void Accionar(Coordenada coor) {

        }

        protected void InsertarObjetoACuadrante(IAccionable objeto)
        {
            List<Coordenada> coordendasLibres = ObtenerCoordenadasLibres().ToList();
            Random ran = new Random();
            Coordenada coor = coordendasLibres[ran.Next(0, coordendasLibres.Count - 1)];
            Cuadrantes[coor.X, coor.Y] = objeto;
        }

        private IEnumerable<Coordenada> ObtenerCoordenadasLibres()
        {
            for (int x = 0; x < Cuadrantes.GetLength(0); x++)
            {
                for (int y = 0; y < Cuadrantes.GetLength(1); y++)
                {
                    if (Cuadrantes[x,y] == null)
                    {
                        yield return new Coordenada(x,y);
                    }
                }
            }
        }
    }
}
