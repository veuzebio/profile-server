using MediatR;
using Profile.Application.CharacterApp.Commands.Validators;

namespace Profile.Application.CharacterApp.Commands
{
    /// <summary>
    /// Contains the information needed to create a new character
    /// </summary>
    public class CreateNewCharacterCommand : ValidCommand, IRequest<Guid>
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

        /// <summary>
        /// Validates command properties.
        /// </summary>
        /// <returns>Validation result.</returns>
        public override bool IsValid()
        {
            ValidationResult = new CreateNewCharacterCommandValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
