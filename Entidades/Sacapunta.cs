using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        public enum eTipo
        {
            plastico,
            metal
        }

        private eTipo tipo;
        private int id;

        public eTipo Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; }


        public Sacapunta(int id, string marca, decimal precio, eTipo tipo):base(marca,precio)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.id}");
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }
    }
}
