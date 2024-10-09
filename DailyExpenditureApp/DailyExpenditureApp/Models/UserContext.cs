using DailyExpenditureApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DailyExpenditureApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserModel> Expenses { get; set; }
    }
}
