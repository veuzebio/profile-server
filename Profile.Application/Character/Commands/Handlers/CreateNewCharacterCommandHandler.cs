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

        /// <summary>
        /// Handles creating a new character and saving it in the repository.
        /// </summary>
        /// <param name="request">Information needed to create a new character.</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <returns>The Id of the created <see cref="Character">character</see>.</returns>
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
