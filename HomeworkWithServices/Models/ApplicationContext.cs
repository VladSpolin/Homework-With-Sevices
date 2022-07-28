using HomeworkWithServices.Models.DataBaseModels;
using HomeworkWithServices.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace HomeworkWithServices.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().Property(w => w.Number).HasMaxLength(15);
            modelBuilder.Seed();
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
