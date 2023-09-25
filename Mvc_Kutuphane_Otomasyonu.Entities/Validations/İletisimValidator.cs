using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class İletisimValidator:AbstractValidator<Iletisim>
    {
        public İletisimValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email Alanı En Fazla 150 Karakter Olablir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Bir Mail Adresi Formatını Giriniz.");

            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı Alanı Boş Geçilemez");
            RuleFor(x => x.AdiSoyadi).MaximumLength(100).WithMessage("Adı Soyadı alanı en fazla 100 karakter olabilir.");
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x => x.Baslik).MaximumLength(200).WithMessage("Başlık alanı en fazla 200 karakter olabilir.");
            RuleFor(x => x.Mesaj).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez");
            RuleFor(x => x.Baslik).MaximumLength(500).WithMessage("Başlık alanı en fazla 500 karakter olabilir.");
        }

    }
}
