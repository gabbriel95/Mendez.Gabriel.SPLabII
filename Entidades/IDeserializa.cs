using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IDeserializa
    {
        public Lapiz Deserializar_xmlTextReader(string nombreArchivo);
        public Lapiz DesSerializar_JSON(string nombreArchivo);
    }
}
