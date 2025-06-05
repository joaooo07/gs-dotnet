using global_solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace global_solution.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EstacaoMeteorologica> Estacoes { get; set; }
        public DbSet<LeituraTemperatura> Leituras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EstacaoMeteorologica>()
                .HasMany(e => e.Leituras)
                .WithOne(l => l.Estacao)
                .HasForeignKey(l => l.EstacaoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
