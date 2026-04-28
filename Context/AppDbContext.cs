using Microsoft.EntityFrameworkCore;
using MoneyFlow.Entities;

namespace MoneyFlow.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(e =>
            {
                e.HasKey("UserID");
                e.Property("UserID").ValueGeneratedOnAdd();

                e.HasData(
                  
                    new Users() { UserID = 1, UserName = "Cristopher Mariñez" , Password="Cris123"}
                    );
                
            });
        }


    }
}
