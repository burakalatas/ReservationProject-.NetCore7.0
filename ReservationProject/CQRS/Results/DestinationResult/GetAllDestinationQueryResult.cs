namespace ReservationProject.CQRS.Results.DestinationResult
{
    public class GetAllDestinationQueryResult
    {
        public int id { get; set; }
        public string? cityStart { get; set; }
        public string? cityEnd { get; set; }
        public string? daynight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
    }
}
