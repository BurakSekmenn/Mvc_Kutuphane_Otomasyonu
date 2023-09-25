using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(x => x.BarkodNo).NotEmpty().WithMessage("Barkod Alanı Boş Geçilemez");
            RuleFor(x => x.BarkodNo).MaximumLength(30).WithMessage("Barkod No alanı en fazla 30 karakter olabilir.");


            RuleFor(x => x.KitapAdi).NotEmpty().WithMessage("Kitap Adı Alanı Boş Geçilemez");
            RuleFor(x => x.KitapAdi).MaximumLength(100).WithMessage("Kitap Adi alanı en fazla 100 karakter olabilir.");

            RuleFor(x => x.YazarAdi).NotEmpty().WithMessage("Yazar Adı Alanı Boş Geçilemez");
            RuleFor(x => x.YazarAdi).MaximumLength(100).WithMessage("Yazar Ad alanı en fazla 100 karakter olabilir.");

            RuleFor(x => x.YayinEvi).NotEmpty().WithMessage("YayınEvi Alanı Boş Geçilemez");
            RuleFor(x => x.YayinEvi).MaximumLength(150).WithMessage("Yayınevi alanı en fazla 150 karakter olabilir.");
        }
    }
}
