using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public RemoveBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _brandRepository.GetByIdAsync(command.Id);
            await _brandRepository.RemoveAsync(value);
        }
    }
}
