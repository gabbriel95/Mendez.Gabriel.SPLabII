using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;

namespace Entidades
{
    public class Lapiz : Utiles, IDeserializa, ISerializa
    {
        private static string rutaBase;
        public enum eColor
        {
            Rojo,
            Verde,
            Azul,
            Negro
        }

        private eColor color;

        public eColor Color { get => color; set => color = value; }
        public static string RutaBase { get => rutaBase; set => rutaBase = value; }

        static Lapiz()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Archivos_Serializados\\");
            rutaBase = info.FullName;
        }

        public Lapiz() 
        {
        
        }

        public Lapiz(string marca, decimal precio, eColor color, int idCartuchera) : base(marca, precio, idCartuchera)
        {
            this.color = color;
        }
        public Lapiz(int id, string marca, decimal precio, eColor color, int idCartuchera) : base(id, marca, precio, idCartuchera)
        {
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"id_cartuchera: {this.IdCartuchera}");

            return sb.ToString();
        }

      

    }
}
