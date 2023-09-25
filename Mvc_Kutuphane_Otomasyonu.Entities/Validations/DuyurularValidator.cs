using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class DuyurularValidator:AbstractValidator<Duyrular>
    {
        public DuyurularValidator()
        {
            RuleFor(x=>x.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x=>x.Duyuru).NotEmpty().WithMessage("Duyuru Alanı Boş Geçilemez");
            RuleFor(x => x.Tarih).NotEmpty().WithMessage("Tarih Alanı Boş Geçilemez");
            RuleFor(x => x.Baslik).Length(5, 150).WithMessage("Başlık alanı 5-150 karakter arasında olmalıdır.");
            RuleFor(x => x.Duyuru).MaximumLength(500).WithMessage("Duyuru alanı en fazla 500 karakter arasında olmalıdır.");
           
            
        }
    }
}
