using FluentValidation;
using FoodForYou.API.Models;

namespace FoodForYou.API.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(60).WithMessage("Título pode ter no máximo 60 caracteres");
        }
    }
}