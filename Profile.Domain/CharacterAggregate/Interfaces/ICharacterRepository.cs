using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Domain.CharacterAggregate.Interfaces
{
    /// <summary>
    /// Handles database operations for <see cref="Character">character</see>./>.
    /// </summary>
    public interface ICharacterRepository
    {
        /// <summary>
        /// Add a new <see cref="Character">character</see> to the database.
        /// </summary>
        /// <param name="character">Character profile.</param>
        public Task CreateAsync(Character character);

        /// <summary>
        /// Retrieves a specific <see cref="Character">character</see> from the database.
        /// </summary>
        /// <param name="id">The character's identifier</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <returns>The <see cref="Character">character</see> profile if exists.</returns>
        /// <exception cref="Exception">If no character found for the given identifier.</exception>
        public Task<Character> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
