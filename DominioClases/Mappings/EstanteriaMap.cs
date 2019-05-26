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
    public class EstanteriaMap : EntityTypeConfiguration<Estanteria>
    {
        public EstanteriaMap()
        {
            this.ToTable("Estanterias");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Id_Tipo_Estante).HasColumnName("Id_Tipo_Estante").HasColumnType("int");
            this.Property(a => a.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(250);
            this.Property(a => a.Titulo_Estante).HasColumnName("Titulo_Estante").HasColumnType("varchar").HasMaxLength(50);

            this.HasRequired(a => a.Tipo_Estante).WithMany().HasForeignKey(a => a.Id_Tipo_Estante);

            this.Ignore(a => a.Tipo_Estante_Desc);
        }
    }
}
