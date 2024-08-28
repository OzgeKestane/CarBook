using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _blogRepository;

        public CreateBlogCommandHandler(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _blogRepository.CreateAsync(
                new Blog
                {
                    AuthorId = request.AuthorId,
                    CategoryId = request.CategoryId,
                    CoverImageUrl = request.CoverImageUrl,
                    CreatedDate = request.CreatedDate,
                    Title = request.Title
                });
        }
    }
}
