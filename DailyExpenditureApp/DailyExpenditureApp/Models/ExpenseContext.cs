using Microsoft.EntityFrameworkCore;

namespace DailyExpenditureApp.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ExpenseModel> Expenses { get; set; }
    }
}
