using CVApp.DTO.DTO.InterestDTO;
using FluentValidation;

namespace CVApp.Bussiness.ValidationRules.InterestValidators
{
    public class InterestUpdateValidator : AbstractValidator<InterestUpdateDTO>
    {
        public InterestUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Title alanı boş geçilemez");
          
            RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");

        }
    }
}
