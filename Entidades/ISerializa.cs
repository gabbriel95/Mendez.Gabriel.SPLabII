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
    public interface ISerializa <T,U> where T : Lapiz where U : Fibron
    {
        public static void Serializar_XmlTextWritter(string nombreArchivo, T util)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Lapiz.RutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                xmlTextWriter.Formatting = Formatting.Indented;
                xml.Serialize(xmlTextWriter, util);
            }
        }

        public static void Serializar_JSON(string nombreArchivo, T util)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Lapiz.RutaBase}{nombreArchivo}"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string ser = JsonSerializer.Serialize(util, options);
                streamWriter.WriteLine(ser);
            }
        }
    }
}
