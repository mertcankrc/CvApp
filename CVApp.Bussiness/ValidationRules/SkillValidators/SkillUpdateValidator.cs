using CVApp.DTO.DTO.SkillDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.SkillValidators
{
    public class SkillUpdateValidator : AbstractValidator<SkillUpdateDTO>
    {
        public SkillUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
        }
    }
}
