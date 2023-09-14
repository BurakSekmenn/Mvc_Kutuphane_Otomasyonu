﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model
{
    public class Uyeler
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string ResimYolu { get; set; }
        public int OkuKitapSayisi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public List<EmanetKitaplar> EmanetKitaplar { get; set; }
    }
}
