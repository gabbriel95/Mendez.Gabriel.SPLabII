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


        static Lapiz()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Archivos_Serializados\\");
            rutaBase = info.FullName;
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

        public Lapiz Deserializar_xmlTextReader(string nombreArchivo)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Lapiz.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                Lapiz lapiz = xml.Deserialize(xmlTextReader) as Lapiz;

                return lapiz;
            }
        }

        public Lapiz DesSerializar_JSON(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Lapiz.rutaBase}{nombreArchivo}"))
            {
                string json = streamReader.ReadToEnd();
                return JsonSerializer.Deserialize<Lapiz>(json);
            }
        }

        public void Serializar_XmlTextWritter(string nombreArchivo, Lapiz lapiz)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Lapiz.rutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                xmlTextWriter.Formatting = Formatting.Indented;
                xml.Serialize(xmlTextWriter, lapiz);
            }
        }

        public void Serializar_JSON(string nombreArchivo, Lapiz lapiz)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Lapiz.rutaBase}{nombreArchivo}"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string ser = JsonSerializer.Serialize(lapiz, options);
                streamWriter.WriteLine(ser);
            }
        }

    }
}
