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
    public class Tipo_EstanteMap : EntityTypeConfiguration<Tipo_Estante>
    {
        public Tipo_EstanteMap()
        {
            this.ToTable("Tipo_Estantes");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
