using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.StaticHelpers
{
    public static class StaticFileManager
    {
        /// <summary>
        /// convierte el texto rtf de un documento en un string
        /// </summary>
        /// <param name="docPath">path del documento que se quiere leer</param>
        /// <returns>retorna el cuerpo rtf del documento dentro de un string. Si falla retorna ""</returns>
        public static string GetRTFDocPath(string docPath)
        {
            try
            {
                if (!System.IO.File.Exists(docPath))
                    return "";

                StreamReader srDoc = new StreamReader(docPath);
                string cuerpo = srDoc.ReadToEnd();
                srDoc.Close();
                return cuerpo;
            }
            catch (Exception ex)
            {
                LogError(ex);
                return "";
            }
        }

        /// <summary>
        /// Guarda el cuerpoRTF en un archivo en el disco
        /// </summary>
        /// <param name="titulo">titulo del documento</param>
        /// <param name="cuerpoRTF">cuerpo del documento</param>
        /// <returns>retorna true si se guardo con extito</returns>
        public static string SaveRTFDoc(string tituloEstante, string tituloLibro, string tituloCuerpo, string cuerpoRTF)
        {
            try
            {
                if (tituloEstante == "")
                    throw new Exception("No puede guardarse el documento RTF en el disco. Titulo del estante vacio");
                if (tituloCuerpo == "")
                    throw new Exception("No puede guardarse el documento RTF en el disco. Titulo del cuerpo vacio");
                if (cuerpoRTF == "")
                    throw new Exception("No puede guardarse el documento RTF en el disco. Cuerpo del documento vacio");

                tituloEstante = tituloEstante.Replace(" ", "");
                tituloLibro = tituloLibro.Replace(" ", "");
                tituloCuerpo = tituloCuerpo.Replace(" ", "");

                string partialPath = StaticParameters.DocumentosPATH + "\\" + StaticUserLogin.Id.ToString() + "\\" + tituloEstante;
                string fullPath = partialPath + "\\" + tituloLibro + "_" + tituloCuerpo + ".rtf";

                Directory.CreateDirectory(partialPath);

                StreamWriter swDOC = new StreamWriter(fullPath, false);
                swDOC.Write(cuerpoRTF);
                swDOC.Flush();
                swDOC.Close();

                return fullPath;
            }
            catch (Exception ex)
            {
                LogError(ex);
                return "";
            }
        }

        public static bool DeleteRTFDoc(string docPath)
        {
            try
            {
                if (docPath == "" || docPath == null) return true;
                System.IO.File.Delete(docPath);

                return true;
            }
            catch (Exception ex)
            {
                LogError(ex);
                return false;
            }
        }

        public static bool LogError(Exception ex)
        {
            try
            {
                string fileName = "LogError" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                string partialPah = Directory.GetCurrentDirectory() + "\\LogError\\";
                Directory.CreateDirectory(partialPah);
                string fullPath = partialPah + fileName;

                StreamWriter logError;
                if (System.IO.File.Exists(fullPath))
                    logError = new StreamWriter(fullPath, true);
                else
                    logError = File.AppendText(fullPath);

                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("Fecha Error: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("Mensaje error: " + ex.Message);
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine(ex.StackTrace);

                logError.Flush();
                logError.Close();
                return true;
            }
            catch //(Exception excep)
            {
                return false;
            }
        }
    }
}
