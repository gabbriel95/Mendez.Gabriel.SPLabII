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
    public interface IDeserializa <T, U> where T : Lapiz where U : Fibron
    {

        public static T Deserializar_xmlTextReader(string nombreArchivo)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Lapiz.RutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                T util = xml.Deserialize(xmlTextReader) as T;

                return util;
            }
        }

        public static T DesSerializar_JSON(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Lapiz.RutaBase}{nombreArchivo}"))
            {
                string json = streamReader.ReadToEnd();
                return JsonSerializer.Deserialize<T>(json);
            }
        }
    }
}
