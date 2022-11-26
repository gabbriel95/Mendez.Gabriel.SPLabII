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

        public eTipo Tipo { get => tipo; set => tipo = value; }

        public Sacapunta(int id, string marca, decimal precio, eTipo tipo, int idCartuchera):base(id, marca,precio, idCartuchera)
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }
    }
}
