using Microsoft.EntityFrameworkCore;

namespace DailyExpenditureApp.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LocationModel> Expenses { get; set; }
    }
}
