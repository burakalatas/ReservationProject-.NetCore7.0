using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationProject.CQRS.Queries.GuideQueries;
using ReservationProject.CQRS.Results.DestinationResult;
using ReservationProject.CQRS.Results.GuideResults;

namespace ReservationProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuideID,
                GuideDescription = x.GuideDescription,
                GuideImage = x.GuideImage,
                GuideName = x.GuideName
            }).AsNoTracking().ToListAsync();
        }
    }
}
