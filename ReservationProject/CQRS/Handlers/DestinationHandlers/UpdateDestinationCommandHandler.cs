using DataAccessLayer.Concrete;
using ReservationProject.CQRS.Commands.DestinationCommands;

namespace ReservationProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var value = _context.Destinations.Find(command.destinationid);
            value.DestinationStartingCity = command.citystart;
            value.DestinationCity = command.cityend;
            value.DestinationDayNight = command.daynight;
            value.DestinationPrice = command.price;
            value.DestinationCapacity = command.capacity;
            _context.SaveChanges();
        }
    }
}
