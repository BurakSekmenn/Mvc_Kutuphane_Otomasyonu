using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model.Context
{
    public class KutuphaneContext : DbContext
    {
        public KutuphaneContext():base("Kutuphane") { 
        
        
        }

        public DbSet<Duyrular> Duyrulars { get; set; }
        public DbSet<EmanetKitaplar> EmanetKitaplars { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<KitapHareketleri> KitapHareketleris { get; set; }
        public DbSet<KitapKayitHareketleri> kitapKayitHareketleris { get; set; }
        public DbSet<KitapTurleri> KitapTurleris { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleris { get; set; }
        public DbSet<Kullanicilar> kullanicilars { get; set; }
        public DbSet<KullaniciRolleri> kullaniciRolleris { get; set; }
        public DbSet<Roller> rollers { get; set; }
        public DbSet<Uyeler> Uyelers { get; set; }
    }
}
