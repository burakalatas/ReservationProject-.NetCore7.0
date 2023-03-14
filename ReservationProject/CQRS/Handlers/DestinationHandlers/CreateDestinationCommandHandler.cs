using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using ReservationProject.CQRS.Commands.DestinationCommands;

namespace ReservationProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                DestinationCity = command.DestinationCity,
                DestinationStartingCity = command.DestinationStartingCity,
                DestinationDayNight = command.DestinationDayNight,
                DestinationPrice = command.DestinationPrice,
                DestinationStatus = false,
                DestinationCapacity = command.DestinationCapacity
            });
            _context.SaveChanges();
        }
    }
}
