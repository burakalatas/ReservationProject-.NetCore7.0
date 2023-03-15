using MediatR;

namespace ReservationProject.CQRS.Commands.GuideCommands
{
    public class UpdateGuideCommand:IRequest
    {
        public int GuideId { get; set; }
        public string? GuideName { get; set; }
        public string? GuideDescription { get; set; }
        public string? GuideImage { get; set; }
    }
}
