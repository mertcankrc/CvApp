using CVApp.DTO.DTO.InterestDTO;
using FluentValidation;

namespace CVApp.Bussiness.ValidationRules.InterestValidators
{
    public class InterestAddValidator : AbstractValidator<InterestAddDTO>
    {
        public InterestAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
        }
    }
}
