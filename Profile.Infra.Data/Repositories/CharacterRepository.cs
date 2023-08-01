using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Infra.Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ProfileDbContext _context;

        public CharacterRepository(ProfileDbContext context)
        {
            _context = context;
        }

        public void Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
        }

        public Character GetById(Guid Id)
        {
            var result = _context.Characters.Find(Id);

            if (result == null) throw new Exception("Character not found for provided id.");

            return result;
        }
    }
}
