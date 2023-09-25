using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş geçilemez.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email Alanı En Fazla 150 Karakter Olablir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Bir Mail Adresi Formatını Giriniz.");

            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı Alanı Boş Geçilemez");
            RuleFor(x => x.AdiSoyadi).MaximumLength(100).WithMessage("Adı Soyadı alanı en fazla 100 karakter olabilir.");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanici Adı Alanı Boş Geçilemez");
            RuleFor(x => x.KullaniciAdi).MaximumLength(30).WithMessage("Kullanici Adı Alanı en fazla 30 karakter olabilir.");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.Sifre).MaximumLength(15).WithMessage("Şifre Alanı fazla 15 karakter olabilir.");

            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez");
            RuleFor(x => x.Telefon).MaximumLength(20).WithMessage("Telefon Alanı fazla 15 karakter olabilir.");

            RuleFor(x => x.Adres).NotEmpty().WithMessage("Adres Alanı Boş Geçilemez");
            RuleFor(x => x.Adres).MaximumLength(20).WithMessage("Adres Alanı fazla 500 karakter olabilir.");
        }
    }
}
