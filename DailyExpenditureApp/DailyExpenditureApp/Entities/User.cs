namespace DailyExpenditureApp.Entities
{
    public class User
    {
        private int UserID { get; set; }
        private string UserName { get; set; } = "";
        private DateOnly DoB { get; set; }
        private byte[] profilePicture { get; set; } = [];
        private string password { get; set; } = "";
    }
}