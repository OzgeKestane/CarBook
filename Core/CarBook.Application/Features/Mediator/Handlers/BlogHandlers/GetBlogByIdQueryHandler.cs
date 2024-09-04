using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _blogRepository;

        public GetBlogByIdQueryHandler(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                CoverImageUrl = values.CoverImageUrl,
                BlogId = values.BlogId,
                CategoryId = values.CategoryId,
                CreatedDate = values.CreatedDate,
                Title = values.Title,
                AuthorId = values.AuthorId,
                Description = values.Description
            };
        }
    }
}
