using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Domain.CharacterAggregate.Interfaces
{
    public interface ICharacterRepository
    {
        public Task CreateAsync(Character character);
        public Task<Character> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
