using CVApp.DTO.DTO.EducationDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.EducationValidators
{
    public class EducationUpdateValidator : AbstractValidator<EducationUpdateDTO>
    {
        public EducationUpdateValidator()
        {
            //RuleFor(x => x.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Title alanı boş geçilemez");
            //RuleFor(x => x.Title).NotEmpty().WithMessage("Title alanı boş geçilemez"); 
            //RuleFor(x => x.SubTitle).NotEmpty().WithMessage("SubTitle alanı boş geçilemez");
            //RuleFor(x => x.Description).NotEmpty().WithMessage("Id alanı boş geçilemez");
            //RuleFor(x => x.StartDate).NotEmpty().WithMessage("Id alanı boş geçilemez");

        }
    }
}
