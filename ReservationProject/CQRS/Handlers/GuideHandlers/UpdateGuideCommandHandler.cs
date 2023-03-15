using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using ReservationProject.CQRS.Commands.GuideCommands;

namespace ReservationProject.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;

        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var guide = _context.Guides.Find(request.GuideId);
            guide.GuideName = request.GuideName;
            guide.GuideDescription = request.GuideDescription;
            guide.GuideImage = request.GuideImage;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
