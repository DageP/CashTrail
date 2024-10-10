public class ExpenseDTO
{
    public required string ItemName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public required string PlaceName { get; set; }
    public required string CategoryName { get; set; }
    public int UserID { get; set; }
}