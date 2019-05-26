using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.Clases
{
    public class Libro
    {
        public int Id { get; set; }
        public DateTime Fecha_Add { get; set; }
        public int Id_Estanteria { get; set; }
        public int Id_Usuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Total_Capitulos { get; set; }
        public string Link { get; set; }
        public bool IsPublico { get; set; }
        public bool IsFavorito { get; set; }

        public virtual Estanteria Estanteria { get; set; }
        public virtual Usuario Usuario { get; set; }

        public string Titulo_Estanteria { get { return Estanteria.Titulo_Estante; } }
        public string Usuario_Nombre { get { return Usuario.Nombre; } }

        public Libro()
        {
            Titulo = "";
            Descripcion = "";
            Total_Capitulos = 0;
            Link = "";
            IsPublico = false;
            IsFavorito = false;
        }
    }
}
