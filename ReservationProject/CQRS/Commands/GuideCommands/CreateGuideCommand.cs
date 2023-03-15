using MediatR;

namespace ReservationProject.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string? GuideName { get; set; }
        public string? GuideDescription { get; set; }
        public string? GuideImage { get; set; }
    }
}
