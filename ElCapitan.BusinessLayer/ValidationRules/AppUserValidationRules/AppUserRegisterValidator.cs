using ElCapitan.DtoLayer.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x=>x.Email).EmailAddress().WithMessage("Email is not correct");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Surname cannot be empty");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(x=>x.ConfirmPassword).Equal(x=>x.Password).WithMessage("Name cannot be empty");


        }
    }
}
