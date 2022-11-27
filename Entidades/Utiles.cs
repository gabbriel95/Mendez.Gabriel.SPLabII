using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Lapiz))]
    public abstract class Utiles
    {
        private int idUtil;
        private string marca;
        private decimal precio;
        private int idCartuchera;
        public string Marca { get => marca; set => marca = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int IdCartuchera { get => idCartuchera; set => idCartuchera = value; }
        public int IdUtil { get => idUtil; set => idUtil = value; }

        public Utiles(string marca, decimal precio, int idCartuchera)
        {
            this.marca = marca;
            this.precio = precio;
            this.idCartuchera = idCartuchera;
        }

        public Utiles(int id, string marca, decimal precio, int idCartuchera)
        {
            this.idUtil = id;
            this.marca = marca;
            this.precio = precio;
            this.idCartuchera = idCartuchera;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.idUtil}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Precio: {this.precio}");

            return sb.ToString();   
        }
    }
}
