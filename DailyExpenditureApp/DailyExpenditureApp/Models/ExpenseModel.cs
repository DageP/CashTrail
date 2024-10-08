using DailyExpenditureApp.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyExpenditureApp.Models
{
    public class Expense
    {
        [Key]
        public string ItemName { get; set; } = "";
        [Required]
        [Column(TypeName = "smallint")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double Price { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateOnly DateOfPurchase { get; set; }
        [Key]
        public int LocationID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100")]
        public string Category { get; set; } = "";
        [Required]
        [Column(TypeName = "smallint")]
        public int UserID { get; set; }
    }
}
