using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StoreItemsContext : DbContext
    {
        public StoreItemsContext(DbContextOptions options): base(options)
        {
           
        }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(m =>
            {
                m.ToTable("Item");
                m.Property(x => x.Id)
                 .HasColumnType("TEXT") //SQLite gotcha that does not have a GUID type 
                 .HasConversion(
                  x => x.ToString(),
                  x => Guid.Parse(x)
                  );
                m.HasKey(x => x.Id);
                m.Property(x => x.Title).IsRequired().HasMaxLength(50);
                m.Property(x => x.Description).IsRequired().HasMaxLength(200);
                m.Property(x => x.DeletedBy).IsRequired(false);
                m.Property(x => x.DeletedDate).IsRequired(false);
                m.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();
                m.HasQueryFilter(x => x.DeletedDate == null);
            });
            
        }

        public override Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            var now = DateTime.UtcNow;

            foreach (var e in ChangeTracker.Entries<Item>())
            {
                switch (e.State)
                {
                    case EntityState.Added:
                        e.Property(x => x.CreateDate).CurrentValue = now;
                        e.Property(x => x.UpdateDate).CurrentValue = now;
                        // ensure non-null concurrency value
                        if (string.IsNullOrEmpty(e.Property(x => x.ConcurrencyStamp).CurrentValue))
                            e.Property(x => x.ConcurrencyStamp).CurrentValue = Guid.NewGuid().ToString("N");
                        break;

                    case EntityState.Modified:
                        e.Property(x => x.UpdateDate).CurrentValue = now;
                        // create concurrency token
                        e.Property(x => x.ConcurrencyStamp).CurrentValue = Guid.NewGuid().ToString("N");
                        break;
                }
            }

            return base.SaveChangesAsync(ct);
        }


    }
}
