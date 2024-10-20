using Microsoft.EntityFrameworkCore;

namespace DailyExpenditureApp.Models
{
    public class ExpenseDetailContext : DbContext
    {
        public ExpenseDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ExpenseModel> Expenses { get; set; }
        public DbSet<LocationModel> Locations { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Assigns a random GUID from SQL Server
            modelBuilder.Entity<ExpenseModel>()
                .Property(e => e.ExpenseID)
                .HasDefaultValueSql("NEWID()");

            // Configure to use auto-incrementing for the ID
            modelBuilder.Entity<LocationModel>()
                .Property(e => e.LocationID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserModel>()
                .Property(e => e.UserID)
                .ValueGeneratedOnAdd();
        }
    }
}
