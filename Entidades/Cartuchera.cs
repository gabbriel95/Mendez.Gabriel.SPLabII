using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera <T> where T : Utiles
    {
        public delegate void CartucheraAction(object cartuchera, EventArgs e);
        public event CartucheraAction EventoPrecio;

        private List<T> utiles;
        private int capacidad;

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public List<T> Utiles { get => utiles; }
        public decimal PrecioTotal 
        {
            get {
                decimal precioTotal = 0;
                foreach (T element in utiles) 
                {
                    precioTotal += element.Precio;
                }

                return precioTotal;
            }
        }

        public Cartuchera(List<T> utiles, int capacidad)
        {
            this.utiles = utiles;
            this.capacidad = capacidad;
        }

        public bool hayCapacidad()
        {
            return this.utiles.Count < this.capacidad;
        }

        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera, T util) 
        {
            if (!cartuchera.hayCapacidad()) 
            {
                throw new CartucheraLlenaException("No hay capacidad en la cartuchera");
            }
           
            cartuchera.Utiles.Add(util);

            if (cartuchera.PrecioTotal > 500 && cartuchera.EventoPrecio is not null)
            {
                cartuchera.EventoPrecio.Invoke(cartuchera,e);
            }

            return cartuchera;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T element in utiles) 
            {
                sb.AppendLine(element.ToString());
            }
            return sb.ToString();
        }

    }
}
