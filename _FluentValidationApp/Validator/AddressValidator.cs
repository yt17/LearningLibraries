using _FluentValidationApp.Models;
using FluentValidation;

namespace _FluentValidationApp.Validator
{
    public class AddressValidator:AbstractValidator<UserAddress>
    {
        public AddressValidator()
        {
            RuleFor(w => w.CityCode).NotEmpty();
        }
    }
}
