using CVApp.DTO.DTO.ExperienceDTO;
using FluentValidation;


namespace CVApp.Bussiness.ValidationRules.ExperienceValidators
{
    public class ExperienceUpdateValidator : AbstractValidator<ExperienceUpdateDTO>
    {
        public ExperienceUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Title alanı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title alanı boş geçilemez"); 
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("SubTitle alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Id alanı boş geçilemez");

        }
    }
}
