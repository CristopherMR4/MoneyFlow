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
                  
                    new Users() { UserID = 1, UserName = "Cristopher Mariñez" , Email = "Cris12@gmail.com", Password ="Cris123"}
                    );
                
            });

            modelBuilder.Entity<Services>(s =>
            {
                s.HasKey("ServiceID");
                s.Property("ServiceID").ValueGeneratedOnAdd();

                s.HasOne( u => u.ObjUser).WithMany(u => u.IServices).HasForeignKey(u => u.Userid)
                .OnDelete(DeleteBehavior.Cascade);//revisar luego se puede cambiar por restirngido

            });

            modelBuilder.Entity<Transactions>(s => {

                s.HasKey("TransactionID");
                s.Property("TransactionID").ValueGeneratedOnAdd();
                //correcion para evitar la alerta al crear la migracion
                s.Property("Date").HasColumnType("date");
                s.Property("TotalAmount").HasColumnType("decimal(10,2)");

                //referencias a las llaves foreaneas

                //Service

                s.HasOne( s => s.Objservice).WithMany().HasForeignKey( s => s.Serviceid)
                .OnDelete(DeleteBehavior.Cascade);

                //usuario
                s.HasOne( u => u.ObjUser).WithMany(u => u.ITransactions).HasForeignKey(u => u.Userid)
                .OnDelete(DeleteBehavior.Cascade);
            
            
            });
        }


    }
}
