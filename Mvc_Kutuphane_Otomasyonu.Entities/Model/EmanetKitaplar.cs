using FluentValidation.Attributes;
using Mvc_Kutuphane_Otomasyonu.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model
{
    [Validator(typeof(EmanetKitaplarValidator))]
    public class EmanetKitaplar
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public int KitapSayisi { get; set; }
        public DateTime KitapAldigiTarih { get; set; }
        public DateTime KitapIadeTarihi { get; set; }

        public Kitap Kitap { get; set; }
        public Uyeler Uyeler { get; set; }

    }
}
