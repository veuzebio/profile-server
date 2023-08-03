using FluentValidation;

namespace Profile.Application.CharacterApp.Commands.Validators
{
    public class CreateNewCharacterCommandValidator: AbstractValidator<CreateNewCharacterCommand>
    {
        public CreateNewCharacterCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(4);

            RuleFor(x => x.Items)
                .NotEmpty();
        }
    }
}
