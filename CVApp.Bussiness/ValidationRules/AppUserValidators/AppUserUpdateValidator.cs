using CVApp.DTO.DTO.AppUserDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.ValidationRules.AppUserValidators
{
    public class AppUserUpdateValidator : AbstractValidator<AppUserUpdateDTO>
    {
        public AppUserUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
