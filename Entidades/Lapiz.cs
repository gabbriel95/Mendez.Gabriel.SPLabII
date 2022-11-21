using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        public enum eColor 
        {
            Rojo,
            Verde,
            Azul,
            Negro
        }

        private eColor color;

        public eColor Color { get => color; set => color = value; }

        public Lapiz(string marca, decimal precio, eColor color) : base(marca, precio)
        {
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }
    }
}
