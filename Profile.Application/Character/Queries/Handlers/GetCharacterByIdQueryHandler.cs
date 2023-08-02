using MediatR;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Application.Resume.Queries.Handlers
{
    public class GetCharacterByIdQueryHandler : IRequestHandler<GetCharacterByIdQuery, Character>
    {
        private readonly ICharacterRepository _repository;

        public GetCharacterByIdQueryHandler(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public async Task<Character> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
