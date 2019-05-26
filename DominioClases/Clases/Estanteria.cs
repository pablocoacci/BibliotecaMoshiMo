using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.Clases
{
    public class Estanteria
    {
        public int Id { get; set; }
        public int Id_Tipo_Estante { get; set; }
        public string Titulo_Estante { get; set; }
        public string Descripcion { get; set; }
        public virtual Tipo_Estante Tipo_Estante { get; set; }
        public virtual List<Libro> Libros { get; set; }

        public string Tipo_Estante_Desc { get { return Tipo_Estante.Descripcion; } }
    }
}
