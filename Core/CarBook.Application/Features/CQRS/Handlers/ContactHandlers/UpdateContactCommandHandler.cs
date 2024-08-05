using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactId);
            values.ContactId = command.ContactId;
            values.Subject = command.Subject;
            values.Email = command.Email;
            values.Message = command.Message;
            values.Name = command.Name;
            values.SendDate = command.SendDate;
            await _repository.UpdateAsync(values);
        }
    }
}
