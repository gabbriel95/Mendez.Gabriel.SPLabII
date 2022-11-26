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

        public eTamanio Tamanio { get => tamanio; set => tamanio = value; }


        public Goma(int id, string marca, decimal precio, eTamanio tamanio, int idCartuchera): base(id, marca, precio, idCartuchera)
        {
            this.tamanio = tamanio;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.tamanio}");

            return sb.ToString();
        }
    }
}
