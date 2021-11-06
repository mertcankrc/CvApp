using CVApp.DTO.DTO.SkillDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.SkillValidators
{
    public class SkillAddValidator : AbstractValidator<SkillAddDTO>
    {
        public SkillAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
        }
    }
}
