using CarBook.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
