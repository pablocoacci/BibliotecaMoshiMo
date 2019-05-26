using DominioClases.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.Mappings
{
    public class CapituloMap : EntityTypeConfiguration<Capitulo>
    {
        public CapituloMap()
        {
            this.ToTable("Capitulos");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Fecha_Add).HasColumnName("Fecha_Add").HasColumnType("datetime");
            this.Property(a => a.Id_Libro).HasColumnName("Id_Libro").HasColumnType("int");
            this.Property(a => a.Titulo).HasColumnName("Titulo").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.DocPath).HasColumnName("DocPath").HasColumnType("varchar").HasMaxLength(1500);
            this.Property(a => a.ContenidoCuerpo).HasColumnName("ContenidoCuerpo").HasColumnType("nvarchar");

            
            //this.Ignore(a => a.Cuerpo);
        }
    }
}
