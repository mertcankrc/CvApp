using CVApp.DTO.DTO.EducationDTO;
using CVApp.DTO.DTO.ExperienceDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.ExperienceValidators
{
    public class ExperienceAddValidator : AbstractValidator<ExperienceAddDTO>
    {
        public ExperienceAddValidator()
        {
            //RuleFor(x => x.Title).NotEmpty().WithMessage("Title alanı boş geçilemez"); 
            //RuleFor(x => x.SubTitle).NotEmpty().WithMessage("SubTitle alanı boş geçilemez");
            //RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
            //RuleFor(x => x.StartDate).NotEmpty().WithMessage("Id alanı boş geçilemez");

        }
    }
}
