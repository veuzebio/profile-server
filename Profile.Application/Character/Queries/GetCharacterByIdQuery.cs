using MediatR;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Application.Resume.Queries
{
    public class GetCharacterByIdQuery: IRequest<Character>
    {
        public Guid Id { get; set; }
    }
}
