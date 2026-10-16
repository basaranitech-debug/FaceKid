using FaceKid.ViewModels.Post;
using FluentValidation;

namespace FaceKid.Validators.Post
{
    public class CreatePostViewModelValidator : AbstractValidator<CreatePostViewModel>
    {
        public CreatePostViewModelValidator() 
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Paylaşım boş olamaz.")
                .MaximumLength(500)
                .WithMessage("Paylaşım en fazla 500 karater olabilir!");
        }
    }
}
