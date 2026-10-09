using FaceKid.ViewModels.Account;
using FluentValidation;

namespace FaceKid.Validators.Account
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator() 
        {

            RuleFor(x => x.FullName)
                .NotEmpty()
                .WithMessage("Ad soyad boş bırakılamaz.");

            RuleFor(x => x.Email)
                    .NotEmpty()
                    .WithMessage("Email boş bırakılamaz.")
                    .EmailAddress()
                    .WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(x => x.Password)
                    .NotEmpty()
                    .WithMessage("Şifre boş olamaz")
                    .MinimumLength(6)
                    .WithMessage("Şifre en az 6 karakterden oluşmalıdır!");

            RuleFor(x => x.ConfirmPassword)
                    .Equal(x => x.Password)
                    .WithMessage("Şifreler eşleşmiyor!");

        }
    }
}
