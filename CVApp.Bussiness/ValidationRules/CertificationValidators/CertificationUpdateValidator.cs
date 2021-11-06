using CVApp.DTO.DTO.CertificationDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.CertificationValidators
{
    public class CertificationUpdateValidator : AbstractValidator<CertificationUpdateDTO>
    {
        public CertificationUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description alanı boş geçilemez");
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
