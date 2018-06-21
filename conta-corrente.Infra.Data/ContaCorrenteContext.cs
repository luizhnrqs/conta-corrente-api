using ContaCorrente.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContaCorrente.Infra.Data
{
    public class ContaCorrenteContext : DbContext
    {
        public ContaCorrenteContext(DbContextOptions<ContaCorrenteContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Conta> Conta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Agencia>().ToTable("Agencia");
            modelBuilder.Entity<Conta>().ToTable("Conta");
        }
    }
}
