using MediatR;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Application.Resume.Queries
{
    /// <summary>
    /// Query with the information needed to get a specific character.
    /// </summary>
    public class GetCharacterByIdQuery: IRequest<Character>
    {
        /// <summary>
        /// Character's id.
        /// </summary>
        public Guid Id { get; set; }
    }
}
