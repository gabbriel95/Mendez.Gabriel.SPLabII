using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        public enum eTamanio 
        {
            Chico,
            Mediana,
            Grande
        }

        private eTamanio tamanio;
        private int id;

        public eTamanio Tamanio { get => tamanio; set => tamanio = value; }
        public int Id { get => id; }


        public Goma(int id, string marca, decimal precio, eTamanio tamanio): base(marca, precio)
        {
            this.id = id;
            this.tamanio = tamanio;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.id}");
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.tamanio}");

            return sb.ToString();
        }
    }
}
