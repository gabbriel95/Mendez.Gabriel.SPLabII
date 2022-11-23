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
        private int id;

        public eColor Color { get => color; set => color = value; }

        public int Id { get => id; }

        static Lapiz()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Archivos_Serializados\\");
            rutaBase = info.FullName;
        }

        public Lapiz(int id, string marca, decimal precio, eColor color) : base(marca, precio)
        {
            this.id = id;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.id}");
            sb.AppendLine($"Util: {this.GetType()}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Color: {this.color}");

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
