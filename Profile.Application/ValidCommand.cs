using FluentValidation.Results;
using System.Text.Json.Serialization;

namespace Profile.Application
{
    public abstract class ValidCommand
    {
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        [JsonIgnore]
        public IEnumerable<string> ErrorMessages => ValidationResult.Errors.Select(e => e.ErrorMessage);

        protected ValidCommand()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract bool IsValid();
    }
}
