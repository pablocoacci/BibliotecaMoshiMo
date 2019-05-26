using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.Clases
{
    public class Capitulo
    {
        public int Id { get; set; }
        public DateTime Fecha_Add { get; set; }
        public int Id_Libro { get; set; }
        public string Titulo { get; set; }
        public string DocPath { get; set; }
        public string ContenidoCuerpo { get; set; }

        //private string _cuerpo = "";

        //public string Cuerpo
        //{
        //    get
        //    {
        //        if (_cuerpo == "")
        //            _cuerpo = StaticHelpers.StaticFileManager.GetRTFDocPath(this.DocPath);

        //        return _cuerpo;
        //    }
        //}

    }
}
