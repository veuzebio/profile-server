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

        public Task<Character> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
        {
            var character = _repository.GetById(request.Id);

            return Task.FromResult(character);
        }
    }
}
