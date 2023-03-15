using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using ReservationProject.CQRS.Commands.GuideCommands;

namespace ReservationProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                GuideName = request.GuideName,
                GuideDescription = request.GuideDescription,
                GuideImage = request.GuideImage
            });
            await _context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
