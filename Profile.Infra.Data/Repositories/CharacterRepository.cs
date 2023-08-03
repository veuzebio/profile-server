using Microsoft.EntityFrameworkCore;
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

        public async Task CreateAsync(Character character)
        {
            _context.Characters.Add(character);

            await _context.SaveChangesAsync();
        }

        public async Task<Character> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _context
                .Characters
                .Include(c => c.Items)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

            if (result == null) throw new Exception("Character not found for provided id.");

            return result;
        }
    }
}
