using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianaRooms.Interfaces;

namespace IndianaRooms
{
    class Jugador
    {     
        private List<IAccionable> _inventario { get; set; }
        public Coordenada Posicion { get; private set; }
        public Cuarto Cuarto { get; set; }

        public Jugador(Coordenada posicion, Cuarto cuarto)
        {
            _inventario = new List<IAccionable>();
            Posicion = posicion;
            Cuarto = cuarto;

        }

        public void AgregarInventario(IAccionable accionable)
        {
            _inventario.Add(accionable);
        }

        public void RemoverInventario(Type type)
        {
            IAccionable itemToRemove = null;

            foreach (IAccionable item in _inventario)
            {
                if (item.GetType() == type)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                _inventario.Remove(itemToRemove);
            }
        }

        public IAccionable BuscarItem(Type type)
        {
            foreach (IAccionable item in _inventario)
            {
                if (item.GetType() == type)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
