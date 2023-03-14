namespace ReservationProject.CQRS.Results.DestinationResult
{
    public class GetDestinationByIdQueryResult
    {
        public int destinationid { get; set; }
        public string? citystart { get; set; }
        public string? cityend { get; set; }
        public string? daynight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
    }
}
