﻿using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public UpdateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _brandRepository.GetByIdAsync(command.BrandId);
            values.Name = command.Name;
            await _brandRepository.UpdateAsync(values);
        }
    }
}
