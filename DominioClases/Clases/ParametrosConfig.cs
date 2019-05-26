using DominioClases.StaticHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DominioClases.Clases
{
    public class Parametro
    {
        public enum EnumTipoParametros { ConnectionString, DocumentsPahts };

        public string TipoParametros { get; set; }
        public string Valor { get; set; }
    }

    public class ParametrosConfiguracion
    {
        private string configFilePath = Directory.GetCurrentDirectory() + "\\ParametrosConfig.xml";
        public List<Parametro> Parametros { get; set; }

        public ParametrosConfiguracion()
        {
            Parametros = new List<Parametro>();
        }

        public void GenerateXMLFileConfig()
        {
            try
            {
                if (System.IO.File.Exists(configFilePath))
                    return;

                ParametrosConfiguracion paramConfig = new ParametrosConfiguracion();

                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\DataBase");
                Parametro p1 = new Parametro()
                {
                    TipoParametros = Parametro.EnumTipoParametros.ConnectionString.ToString("g"),
                    Valor = "Data Source =.\\SQLExpress; AttachDbFilename =" + Directory.GetCurrentDirectory() + "\\DataBase\\BibliotecaMoshi.mdf; Database = BibliotecaMoshiDB; Trusted_Connection = Yes"
                };

                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\DocumentosRTF");
                Parametro p2 = new Parametro()
                {
                    TipoParametros = Parametro.EnumTipoParametros.DocumentsPahts.ToString("g"),
                    Valor = System.IO.Directory.GetCurrentDirectory() + "\\DocumentosRTF"
                };

                paramConfig.Parametros.Add(p1);
                paramConfig.Parametros.Add(p2);

                XmlSerializer writer = new XmlSerializer(typeof(ParametrosConfiguracion));
                System.IO.FileStream file = System.IO.File.Create(configFilePath);
                writer.Serialize(file, paramConfig);
                file.Close();
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
            }
        }

        public ParametrosConfiguracion LodXMLFileConfig()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(ParametrosConfiguracion));
                System.IO.StreamReader file = new System.IO.StreamReader(configFilePath);
                ParametrosConfiguracion paramConfig = (ParametrosConfiguracion)reader.Deserialize(file);
                file.Close();

                return paramConfig;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                return null;
            }
        }

        public string GetValorParametros(Parametro.EnumTipoParametros tipo_Parametros)
        {
            ParametrosConfiguracion paramConfig = this.LodXMLFileConfig();

            if (paramConfig == null)
                return "";

            Parametro p = paramConfig.Parametros.Where(a => a.TipoParametros == tipo_Parametros.ToString("g")).FirstOrDefault();

            if (p == null)
                return "";
            else
                return p.Valor;
        }

        public void SetStaticParameters()
        {
            //Si no existe el archivo XML se crea con los parametros por default
            this.GenerateXMLFileConfig();

            //Se lee el archivo XML para levantar los parametros
            ParametrosConfiguracion paramConfig = this.LodXMLFileConfig();

            if (paramConfig == null)
                return;

            //Se configura la clase estatica desde donde se leen los parametros de configuracion
            foreach (Parametro p in paramConfig.Parametros)
                StaticParameters.SetParametro(p);
        }
    }
}
