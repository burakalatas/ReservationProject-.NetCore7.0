namespace ReservationProject.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string? DestinationCity { get; set; }
        public string? DestinationStartingCity { get; set; }
        public string? DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
        public bool DestinationStatus { get; set; }
        public int DestinationCapacity { get; set; }
    }
}
