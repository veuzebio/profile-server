using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Domain.CharacterAggregate.Interfaces
{
    public interface ICharacterRepository
    {
        public void Create(Character character);
        public Character GetById(Guid Id);
    }
}
