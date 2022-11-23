using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Lapiz))]
    public abstract class Utiles
    {
        private string marca;
        private decimal precio;
        public string Marca { get => marca; set => marca = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public Utiles(string marca, decimal precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Precio: {this.precio}");

            return sb.ToString();   
        }
    }
}
