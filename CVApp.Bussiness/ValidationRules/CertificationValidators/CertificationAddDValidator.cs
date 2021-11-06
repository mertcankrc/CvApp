using CVApp.DTO.DTO.CertificationDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.CertificationValidators
{
    public class CertificationAddDValidator : AbstractValidator<CertificationAddDTO>
    {
        public CertificationAddDValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description alanı boş geçilemez");
        }
    }
}
