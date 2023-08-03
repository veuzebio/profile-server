using MediatR;

namespace Profile.Application.Resume.Commands
{
    /// <summary>
    /// Contains the information needed to create a new character
    /// </summary>
    public class CreateNewCharacterCommand: IRequest<Guid>
    {
        /// <summary>
        /// Name of the character
        /// </summary>
        /// <example>John Doe</example>
        public string Name { get; set; }

        /// <summary>
        /// Character's item list
        /// </summary>
        /// <example>["sword", "shield"]</example>
        public string[] Items { get; set; }
    }
}
