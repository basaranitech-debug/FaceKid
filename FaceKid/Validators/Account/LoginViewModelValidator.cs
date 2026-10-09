using FaceKid.ViewModels.Account;
using FluentValidation;

namespace FaceKid.Validators.Account
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator() 
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email boş bırakılamaz!")
                .EmailAddress()
                .WithMessage("Geçerli bir email adresi giriniz");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre boş bırakılamaz!");

        }
    }
}
