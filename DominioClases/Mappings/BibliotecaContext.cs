using DominioClases.Clases;
using DominioClases.StaticHelpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.Mappings
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaLocalDB")
        {
            base.Database.Connection.ConnectionString = StaticParameters.ConnectionString;
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tipo_Estante> Tipo_Estantes { get; set; }
        public DbSet<Estanteria> Estanterias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Capitulo> Capitulos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new Tipo_EstanteMap());
            modelBuilder.Configurations.Add(new EstanteriaMap());
            modelBuilder.Configurations.Add(new LibroMap());
            modelBuilder.Configurations.Add(new CapituloMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
