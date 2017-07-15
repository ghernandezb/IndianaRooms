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
            List<IAccionable> accionables = new List<IAccionable>();
            accionables.Add(new Acertijo("Hasta donde entra un perro en el bosque?"));
            accionables.Add(new Genero(true));
            accionables.Add(new Acertijo("Hasta donde se lava la cara un calvo?"));
            accionables.Add(new Genero(false));
            accionables.Add(new Acertijo("cual es el proposito de la vida?"));
            accionables.Add(new Genero(false));

            foreach (var accionable in accionables)
            {
                Console.WriteLine(accionable.Accionar());
            }
            Console.ReadLine();
        }
    }
}
