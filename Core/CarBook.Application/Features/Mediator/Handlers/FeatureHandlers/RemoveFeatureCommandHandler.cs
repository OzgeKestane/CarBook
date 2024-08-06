using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        private readonly IRepository<Feature> _featureRepository;

        public RemoveFeatureCommandHandler(IRepository<Feature> featureRepository)
        {
            _featureRepository = featureRepository;
        }
        public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _featureRepository.GetByIdAsync(request.Id);
            await _featureRepository.RemoveAsync(value);
        }
    }
}
