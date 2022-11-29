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
    public interface ISerializa
    {
        public static void Serializar_XmlTextWritter(string nombreArchivo, Lapiz lapiz)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Lapiz.RutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                xmlTextWriter.Formatting = Formatting.Indented;
                xml.Serialize(xmlTextWriter, lapiz);
            }
        }

        public static void Serializar_JSON(string nombreArchivo, Lapiz lapiz)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Lapiz.RutaBase}{nombreArchivo}"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string ser = JsonSerializer.Serialize(lapiz, options);
                streamWriter.WriteLine(ser);
            }
        }
    }
}
