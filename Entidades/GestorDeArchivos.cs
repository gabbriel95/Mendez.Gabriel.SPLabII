using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GestorDeArchivos
    {
        static string rutaBase;

        static GestorDeArchivos()
        {
            GestorDeArchivos.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }

        public static bool CrearArchivo(string nombreArchivo, string contenido, bool append)
        {
            StreamWriter stremWriter = null;
            bool retorno = false;

            try
            {
                string nuevaRuta = $"{GestorDeArchivos.rutaBase}\\{nombreArchivo}";
                stremWriter = new StreamWriter(nuevaRuta, append);
                stremWriter.WriteLine(contenido);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al crear archivo", ex);
                
            }
            finally
            {
                if (stremWriter != null)
                {
                    stremWriter.Close();
                }

            }
            return retorno;
        }

        public static string LeerArchivo(string nombreArchivo)
        {
            string retorno = String.Empty;
            try
            {
                string nuevaRuta = $"{GestorDeArchivos.rutaBase}\\{nombreArchivo}";
                using (StreamReader streamReader = new StreamReader(nuevaRuta))
                {
                    retorno = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer", ex);

            }

            return retorno;
        }
    }
}
