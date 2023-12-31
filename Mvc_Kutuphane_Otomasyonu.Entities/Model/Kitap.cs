﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model
{
    public class Kitap
    {
        public int Id { get; set; }

        public string BarkodNo { get; set; }
        public int KitapTuruId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }
        public int StokAdedi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; } = DateTime.Now;
        public bool Silindimi { get; set; } = false;


        public KitapTurleri KitapTurleri { get; set; }//Teki Adlandırma

        public List<EmanetKitaplar> EmanetKitaplar { get; set; }    

        public List<KitapHareketleri> KitapHareketleri { get; set; }

        public List<KitapKayitHareketleri> kitapKayitHareketleri { get; set; }  
    }
}
