using DominioClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.StaticHelpers
{
    public static class StaticParameters
    {
        private static string _connectionString = "";
        private static string _documentosPATH = "";

        public static string ConnectionString { get { return _connectionString; } }
        public static string DocumentosPATH { get { return _documentosPATH; } }

        public static void SetParametro(Parametro p)
        {
            if (p.TipoParametros == Parametro.EnumTipoParametros.ConnectionString.ToString("g"))
                _connectionString = p.Valor;
            else if (p.TipoParametros == Parametro.EnumTipoParametros.DocumentsPahts.ToString("g"))
                _documentosPATH = p.Valor;
        }
    }
}
