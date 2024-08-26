using CarBook.Application.Features.CQRS.Results.AboutResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAboutByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
