using DominioClases.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.DAL
{
    public abstract class Base_DAL
    {
        public string _errorMsg = "";
        public BibliotecaContext _contexto;

        public Base_DAL(BibliotecaContext unContexto = null)
        {
            if (unContexto == null)
                _contexto = new BibliotecaContext();
            else
                _contexto = unContexto;
        }

        public void ResetContexto()
        {
            _contexto= new BibliotecaContext();
        }
    }
}
