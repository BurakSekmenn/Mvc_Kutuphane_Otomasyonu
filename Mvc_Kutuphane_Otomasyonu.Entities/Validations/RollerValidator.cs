using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class RollerValidator:AbstractValidator<Roller>
    {
        public RollerValidator()
        {
            RuleFor(z => z.Rol).NotEmpty().WithMessage("Rol Alanı Boş geçilemez");
            RuleFor(z => z.Rol).MaximumLength(50).WithMessage("Rol Alanı Boş geçilemez");
        }
    }
}
