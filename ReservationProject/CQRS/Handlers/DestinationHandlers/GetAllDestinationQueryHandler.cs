using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using ReservationProject.CQRS.Queries.DestinationQueries;
using ReservationProject.CQRS.Results.DestinationResult;

namespace ReservationProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                cityStart = x.DestinationStartingCity,
                cityEnd = x.DestinationCity,
                daynight = x.DestinationDayNight,
                price = x.DestinationPrice,
                capacity = x.DestinationCapacity
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
