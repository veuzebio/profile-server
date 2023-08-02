using MediatR;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Application.Resume.Commands.Handlers
{
    public class CreateNewCharacterCommandHandler : IRequestHandler<CreateNewCharacterCommand, Guid>
    {
        private readonly ICharacterRepository _repository;

        public CreateNewCharacterCommandHandler(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateNewCharacterCommand request, CancellationToken cancellationToken)
        {
            var items = new List<Item>();

            foreach (var itemName in request.Items)
            {
                items.Add(new Item(itemName));
            }

            var character = new Character(request.Name, items);
            
            await _repository.CreateAsync(character);

            return character.Id;
        }
    }
}
