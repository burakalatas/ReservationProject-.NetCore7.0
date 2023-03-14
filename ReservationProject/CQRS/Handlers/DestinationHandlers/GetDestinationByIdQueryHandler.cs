using DataAccessLayer.Concrete;
using ReservationProject.CQRS.Queries.DestinationQueries;
using ReservationProject.CQRS.Results.DestinationResult;

namespace ReservationProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                destinationid = values.DestinationID,
                citystart = values.DestinationStartingCity,
                cityend = values.DestinationCity,
                daynight = values.DestinationDayNight,
                price = values.DestinationPrice,
                capacity = values.DestinationCapacity
            };
        }
    }
}
