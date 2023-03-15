using DataAccessLayer.Concrete;
using MediatR;
using ReservationProject.CQRS.Commands.GuideCommands;

namespace ReservationProject.CQRS.Handlers.GuideHandlers
{
    public class DeleteGuideCommandHandler : IRequestHandler<DeleteGuideCommand>
    {
        private readonly Context _context;

        public DeleteGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(DeleteGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Remove(_context.Guides.Find(request.id));
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
