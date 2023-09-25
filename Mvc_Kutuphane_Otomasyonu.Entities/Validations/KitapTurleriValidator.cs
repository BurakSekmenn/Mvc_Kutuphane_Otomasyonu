using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KitapTurleriValidator:AbstractValidator<KitapTurleri>
    {
        public KitapTurleriValidator()
        {
            RuleFor(x => x.KitapTuru).NotEmpty().WithMessage("Kitap Turü alanı boş geçilemez");
            RuleFor(x => x.KitapTuru).MaximumLength(150).WithMessage("Kitap Turu alanı en fazla 150 karakter olabilir.");
        }
    }
}
