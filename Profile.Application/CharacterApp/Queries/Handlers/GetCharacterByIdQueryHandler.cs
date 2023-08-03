using MediatR;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Application.CharacterApp.Queries.Handlers
{
    public class GetCharacterByIdQueryHandler : IRequestHandler<GetCharacterByIdQuery, Character>
    {
        private readonly ICharacterRepository _repository;

        public GetCharacterByIdQueryHandler(ICharacterRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Handles getting a specific character from the repository.
        /// </summary>
        /// <param name="request">Information needed to get a specific character.</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <returns>The <see cref="Character">character</see> profile if exists.</returns>
        public async Task<Character> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
