using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyExpenditureApp.Models
{
    public class LocationModel
    {
        [Key]
        public int LocationID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LocationName { get; set; } = "";
        [Required]
        [Column(TypeName = "float")]
        public double Latitude { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double Longitude { get; set; }
    }
}
