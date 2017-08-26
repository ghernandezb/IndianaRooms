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
        public Accionable [,] Cuadrantes { get; private set; }

        public Cuarto(Coordenada coord) {
            Cuadrantes = new Accionable[coord.X, coord.Y];
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

        protected void InsertarObjetoACuadrante(Accionable objeto, bool pared)
        {
            List<Coordenada> camposVacios = pared ? ObtenerVaciosPared().ToList() : ObtenerVacios().ToList();
            Random ran = new Random();
            Coordenada coor = camposVacios[ran.Next(0, camposVacios.Count - 1)];
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

        private IEnumerable<Coordenada> ObtenerVacios()
        {
            for (int x = 0; x < Cuadrantes.GetLength(0); x++)
            {
                for (int y = 0; y < Cuadrantes.GetLength(1); y++)
                {
                    if (Cuadrantes[x, y] == null)
                    {
                        yield return new Coordenada(x, y);
                    }
                }
            }
        }

        private IEnumerable<Coordenada> ObtenerVaciosPared()
        {
            for (int i = 0; i < Cuadrantes.GetLength(1); i++)
            {
                if (Cuadrantes[0, i] == null)
                {
                    yield return new Coordenada(0, i);
                }
                if (Cuadrantes[Cuadrantes.GetLength(0) - 1, i] == null)
                {
                    yield return new Coordenada(Cuadrantes.GetLength(0) - 1, i);
                }
            }
            for (int i = 0; i < Cuadrantes.GetLength(0); i++)
            {
                if (Cuadrantes[i, 0] == null)
                {
                    yield return new Coordenada(i, 0);
                }
                if (Cuadrantes[i, Cuadrantes.GetLength(1) - 1] == null)
                {
                    yield return new Coordenada(i, Cuadrantes.GetLength(1) - 1);
                }
            }
        }
    }
}
