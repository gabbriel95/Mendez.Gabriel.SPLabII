using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializa
    {
        public void Serializar_XmlTextWritter(string nombreArchivo, Lapiz lapiz);
        public void Serializar_JSON(string nombreArchivo, Lapiz lapiz);
    }
}
