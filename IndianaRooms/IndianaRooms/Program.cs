using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cuarto> cuartos = new List<Cuarto>();
            cuartos.Add(new CuartoLlave(new Coordenada(4, 5)));
            Jugador jugador = new Jugador(new Coordenada(0,0), cuartos[0]);
            RenderJuego(jugador);
            Console.ReadLine();
        }

        static void RenderJuego (Jugador jugador)
        {
            var cuadrantes = jugador.Cuarto.Cuadrantes;
            string cuadro;

            for (int x = 0; x < cuadrantes.GetLength(0); x++)
            {
                for (int y = 0; y < cuadrantes.GetLength(1); y++)
                {
                    cuadro = "[";
                    if (jugador.Posicion.X == x && jugador.Posicion.Y == y)
                    {
                        cuadro += "*";
                    }
                    else if (cuadrantes[x,y] != null)
                    {
                        cuadro += cuadrantes[x, y].GetEtiqueta().Substring(0,1);
                    }
                    else
                    {
                        cuadro += " ";
                    }

                    cuadro += "]";
                    Console.Write(cuadro);
                }
                Console.WriteLine("");
            }
        }
    }
}
