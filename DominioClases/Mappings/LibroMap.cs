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
    public class LibroMap : EntityTypeConfiguration<Libro>
    {
        public LibroMap()
        {
            this.ToTable("Libros");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Fecha_Add).HasColumnName("Fecha_Add").HasColumnType("datetime");
            this.Property(a => a.Id_Estanteria).HasColumnName("Id_Estanteria").HasColumnType("int");
            this.Property(a => a.Id_Usuario).HasColumnName("Id_Usuario").HasColumnType("int");
            this.Property(a => a.Titulo).HasColumnName("Titulo").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(250);
            this.Property(a => a.Total_Capitulos).HasColumnName("Total_Capitulos").HasColumnType("int");
            this.Property(a => a.Link).HasColumnName("Link").HasColumnType("varchar").HasMaxLength(1000);
            this.Property(a => a.IsPublico).HasColumnName("IsPublico").HasColumnType("bit");
            this.Property(a => a.IsFavorito).HasColumnName("IsFavorito").HasColumnType("bit");

            this.HasRequired(a => a.Estanteria).WithMany(a => a.Libros).HasForeignKey(a => a.Id_Estanteria);
            this.HasRequired(a => a.Usuario).WithMany().HasForeignKey(a => a.Id_Usuario);

            this.Ignore(a => a.Titulo_Estanteria);
            this.Ignore(a => a.Usuario_Nombre);
        }
    }
}
