using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace XML
{
    public class Serializador<T> : IExportarImportar<T>
    {
        readonly string path;
        
        public Serializador()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AppServicioTecnico\";
        }

        public bool Exportar(T datos)
        {
            bool retorno = false;
            string pathActual = path;

            try
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                pathActual += @"backup.xml";

                if (pathActual != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(pathActual, Encoding.UTF8))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(writer, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public bool Importar(out T datos)
        {
            bool retorno = false;
            datos = default;
            string pathActual = path;

            try
            {
                pathActual += @"backup.xml";
                if (pathActual != null)
                {
                    using (XmlTextReader reader = new XmlTextReader(pathActual))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        datos = (T)serializer.Deserialize(reader);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al leer el achivo desde {path}.");
            }
            return retorno;
        }
    }
}
