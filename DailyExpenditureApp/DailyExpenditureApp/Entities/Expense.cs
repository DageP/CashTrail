using DailyExpenditureApp.Enums;

namespace DailyExpenditureApp.Entities
{
    public class Expense
    {
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; }
        public double Price { get; set; }
        public required Location Place { get; set; } 
        public DateOnly DateOfPurchase { get; set; }
        public Categories Category { get; set; }
        public int UserID { get; set; }
    }
}