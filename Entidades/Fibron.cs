using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fibron : Utiles, IDeserializa<Fibron>, ISerializa<Fibron>
    {
        public delegate void CartucheraAction(object fibron);
        public event CartucheraAction SinTintaEvento;
        public enum eColorFibron
        {
            Rojo,
            Verde,
            Azul,
            Negro
        }

        private int cantidadTinta;
        private int tintaFaltante;
        private eColorFibron color;


        public int CantidadTinta { get => cantidadTinta; set => cantidadTinta = value; }
        public eColorFibron Color { get => color; set => color = value; }
        public int TintaFaltante { get => tintaFaltante; set => tintaFaltante = value; }

        public Fibron() { }


        public Fibron(string marca, decimal precio, int cantidadTinda, eColorFibron color, int idCartuchera) : base(marca, precio, idCartuchera)
        {
            this.cantidadTinta = cantidadTinda;
            this.color = color;
        }

        public Fibron(int id, string marca, decimal precio, int cantidadTinda, eColorFibron color, int idCartuchera) : base(id, marca, precio, idCartuchera)
        {
            this.cantidadTinta = cantidadTinda;
            this.color = color;
        }



        public void Resaltar(int cantidad) //dentro de un try y capturar ex, cuando capturo lanzo el invoke
        {

            try
            {
                if (cantidad <= this.cantidadTinta)
                {
                    cantidadTinta = cantidadTinta - cantidad;
                }
                else
                {
                    cantidadTinta = 0;
                    tintaFaltante = cantidad - cantidadTinta;
                    throw new SinTintaException();
                }
            }
            catch (SinTintaException) 
            {
                SinTintaEvento.Invoke(this);
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
            sb.AppendLine($"Cantidad de tinta faltante: {this.tintaFaltante}");

            return sb.ToString();
        }


    }
}
