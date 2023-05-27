using Microsoft.EntityFrameworkCore;

namespace SEW_Test_240321.model
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options){}

        public DbSet<Artist> Artists { get; set; }
        public DbSet<WorkOfArt> WorkOfArts { get; set; }
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Sculpture> Sculptures { get; set; }
        public DbSet<Setup> Setups { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WorkOfArt>()
                .HasOne(a => a.Artist)
                .WithMany();
        }
    }
}