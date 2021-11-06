using CVApp.DTO.DTO.SkillDTO;
using CVApp.DTO.DTO.SocialMediaDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.SocialMediaValidators
{
    public class SocialMediaAddValidator : AbstractValidator<SocialMediaAddDTO>
    {
        public SocialMediaAddValidator()
        {
            //RuleFor(x => x.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            //RuleFor(x => x.Icon).NotEmpty().WithMessage("Icon alanı boş geçilemez");
            //RuleFor(x => x.Link).NotEmpty().WithMessage("Link alanı boş geçilemez");
        }
    }
}
