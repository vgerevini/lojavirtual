using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;
using TVG.LojaVirtual.Dominio.Entidade.Vitrine;

namespace TVG.LojaVirtual.Dominio.Repositorio
{
    public class EFDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MarcaVitrine> MarcaVitrine { get; set; }
        public DbSet<ClubesNacionais> ClubesNacionais { get; set; }
        public DbSet<ClubesInternacionais> ClubesInternacionais { get; set; }
        public DbSet<Selecoes> Selecoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Administrador>().ToTable("Administradores");
            base.OnModelCreating(modelBuilder);
        }
    }
}
