using Loja.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext: DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        //remover plurazização da convenção do entity framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
