namespace DailyExpenditureApp.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}