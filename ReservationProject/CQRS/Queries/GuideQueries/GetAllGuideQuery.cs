using MediatR;
using ReservationProject.CQRS.Results.GuideResults;

namespace ReservationProject.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
