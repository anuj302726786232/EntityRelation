using EntityRelationAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityRelationAPI.DBContext
{
    public class EntityContext: DbContext
    {

        public EntityContext(DbContextOptions<EntityContext> options): base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne()
            .HasForeignKey(p => p.Id);
        }
    }

}
