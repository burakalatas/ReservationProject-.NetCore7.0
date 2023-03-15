using DataAccessLayer.Concrete;
using MediatR;
using ReservationProject.CQRS.Queries.GuideQueries;
using ReservationProject.CQRS.Results.GuideResults;

namespace ReservationProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler:IRequestHandler<GetGuideByIdQuery,GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID = values.GuideID,
                GuideDescription = values.GuideDescription,
                GuideName = values.GuideName,
                GuideImage = values.GuideImage
            };
        }
    }
}
