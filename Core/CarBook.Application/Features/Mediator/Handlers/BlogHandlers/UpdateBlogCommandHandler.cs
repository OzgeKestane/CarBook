using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _blogRepository;

        public UpdateBlogCommandHandler(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetByIdAsync(request.BlogId);
            values.CreatedDate = request.CreatedDate;
            values.CategoryId = request.CategoryId;
            values.AuthorId = request.AuthorId;
            values.CoverImageUrl = request.CoverImageUrl;
            values.Title = request.Title;
            values.BlogId = request.BlogId;
            await _blogRepository.UpdateAsync(values);
        }
    }
}
