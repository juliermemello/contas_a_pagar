using Contas.Domain.Models;
using Contas.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Contas.Repository.Context
{
    public class EntityContext : DbContext
    {
        public virtual DbSet<ContaPagar> ContasPagar { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ContaPagarMap());
        }
    }
}
