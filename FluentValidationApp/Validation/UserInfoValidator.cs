using FluentValidation;
using FluentValidationApp.Models;

namespace FluentValidationApp.Validation
{
    public class UserInfoValidator:AbstractValidator<UserInfo>
    {
        public UserInfoValidator()
        {
            RuleFor(z=>z.NameSurname).NotEmpty().WithMessage("message Fluent");
        }
    }
}
