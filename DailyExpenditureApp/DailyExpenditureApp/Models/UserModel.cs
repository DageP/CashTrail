using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyExpenditureApp.Models
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = "";
        [Required]
        [Column(TypeName = "date")]
        public DateOnly DoB { get; set; }
        [Column(TypeName = "varbinary(8000)")]
        public byte[] profilePicture { get; set; } = [];
        [Column(TypeName = "nvarchar(100)")]
        public string password { get; set; } = "";
    }
}
