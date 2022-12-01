using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fibron : Utiles, IDeserializa<Lapiz, Fibron>, ISerializa<Lapiz,Fibron>
    {
        public delegate void CartucheraAction(object fibron, EventArgs e);
        public event CartucheraAction SinTintaEvento;
        public enum eColorFibron
        {
            Rojo,
            Verde,
            Azul,
            Negro
        }

        private int cantidadTinta;
        private eColorFibron color;
        private int tintaFaltante;

        public int CantidadTinta { get => cantidadTinta; set => cantidadTinta = value; }
        public eColorFibron Color { get => color; set => color = value; }

        public int TintaFaltante { get => tintaFaltante; set => tintaFaltante = value; }

        public Fibron() { }

        public Fibron(string marca, decimal precio, int cantidadTinda, eColorFibron color) : base(marca, precio, 2)
        {
            this.cantidadTinta = cantidadTinda;
            this.color = color;
        }

        public Fibron(string marca, decimal precio, int cantidadTinda, eColorFibron color, int idCartuchera) : base(marca, precio, idCartuchera)
        {
            this.cantidadTinta = cantidadTinda;
            this.color = color;
        }

        public Fibron(int id, string marca, decimal precio, int cantidadTinda, eColorFibron color, int idCartuchera) : base(id, marca, precio, 2)
        {
            this.cantidadTinta = cantidadTinda;
            this.color = color;
        }

       

        public void Resaltar(int cantidad) 
        {
            if (cantidad <= this.cantidadTinta)
            {
                cantidadTinta = cantidadTinta - cantidad;
            }
            else 
            {
                tintaFaltante = cantidad - cantidadTinta;
                throw new SinTintaException();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"id_cartuchera: {this.IdCartuchera}");
            sb.AppendLine($"Cantidad de tinta: {this.cantidadTinta}");
            sb.AppendLine($"Tinda faltante: {this.TintaFaltante}");

            return sb.ToString();
        }

        public void ManejadorEventoSinTinta()
        {
            EventArgs eventArgs = new EventArgs();
      
            if (SinTintaEvento is not null)
            {
                SinTintaEvento.Invoke(this, eventArgs);
            }

        }

    }
}
