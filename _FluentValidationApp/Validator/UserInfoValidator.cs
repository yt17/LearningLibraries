using _FluentValidationApp.Models;
using FluentValidation;

namespace _FluentValidationApp.Validator
{
    public class UserInfoValidator:AbstractValidator<UserInfo>
    {
        public UserInfoValidator()
        {
            RuleFor(w => w.NameSurname).NotEmpty().MaximumLength(60).WithMessage("Kurallara Uymuyor");
            RuleFor(w => w.BirthDate).NotEmpty().WithMessage("Kurallara Uymuyor").Must(x => { return DateTime.Now.AddYears(-18) >= x; }).WithMessage("18 yasindan buyukl ol");
            RuleForEach(w => w.UserAddresses).SetValidator(new AddressValidator());
            RuleFor(w => w.Cinsiyet).IsInEnum().WithMessage("enum olmali");
        }
    }
}
