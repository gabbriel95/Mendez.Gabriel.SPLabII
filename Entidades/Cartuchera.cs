using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        public delegate void CartucheraAction(object cartuchera, EventArgs e);
        public event CartucheraAction EventoPrecio;

        private List<T> utiles;
        private int capacidad;
        private int id;

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public List<T> Utiles { get => utiles;}
        public int Id { get => id; }
        public decimal PrecioTotal
        {
            get
            {
                decimal precioTotal = 0;
                foreach (T element in utiles)
                {
                    precioTotal += element.Precio;
                }

                return precioTotal;
            }
        }

        public Cartuchera(int capacidad)
        {
            this.capacidad = capacidad;
        }


        public Cartuchera(int id, int capacidad): this (capacidad)
        {
            this.id = id;
        }

        public Cartuchera(List<T> utiles, int capacidad) : this(capacidad)
        {
            this.utiles = utiles;
            this.capacidad = capacidad;
        }

        public Cartuchera(int id, List<T> utiles, int capacidad) : this(id, capacidad)
        {
            this.utiles = utiles;
            this.id = id;
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

            /*if (cartuchera.PrecioTotal > 100 && cartuchera.EventoPrecio is not null)
            {
                
            }*/

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

        public void Ejecutar() 
        {
            EventArgs eventArgs = new EventArgs();
            if (EventoPrecio is not null) 
            {
                EventoPrecio.Invoke(this, eventArgs);
            }
        }



    }
}
