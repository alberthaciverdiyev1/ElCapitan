using ElCapitan.DtoLayer.SettingDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.BusinessLayer.ValidationRules.SettingValidationRules
{
    public class SettingAddValidator:AbstractValidator<SettingAddDtos>
    {
        public SettingAddValidator()
        {
            RuleFor(x => x.Key).NotEmpty().WithMessage("Key cannot be null");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value cannot be null");
        }
    }
}
