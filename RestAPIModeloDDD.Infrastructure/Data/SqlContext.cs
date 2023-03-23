using Microsoft.EntityFrameworkCore;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                    if (entry.Entity.GetType().GetProperty("IsAtivo") != null)
                    {
                        entry.Property("IsAtivo").CurrentValue = true;
                    }
                    if (entry.Entity.GetType().GetProperty("IsDisponivel") != null)
                    {
                        entry.Property("IsDisponivel").CurrentValue = true;
                    }

                                                        
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;

                    if (entry.Entity.GetType().GetProperty("IsAtivo") != null)
                    {
                        entry.Property("IsAtivo").IsModified = false;
                    }
                    if (entry.Entity.GetType().GetProperty("IsDisponivel") != null)
                    {
                        entry.Property("IsDisponivel").IsModified = false;
                    }
                }

            }
            return base.SaveChanges();
        }

    }
}
