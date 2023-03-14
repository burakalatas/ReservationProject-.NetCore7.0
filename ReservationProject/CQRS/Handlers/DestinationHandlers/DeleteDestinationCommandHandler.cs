using DataAccessLayer.Concrete;
using ReservationProject.CQRS.Commands.DestinationCommands;

namespace ReservationProject.CQRS.Handlers.DestinationHandlers
{
    public class DeleteDestinationCommandHandler
    {
        private readonly Context _context;

        public DeleteDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(DeleteDestinationCommand command)
        {
            var value = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
        }
    }
}
