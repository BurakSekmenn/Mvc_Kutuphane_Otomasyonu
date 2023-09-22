using Mvc_Kutuphane_Otomasyonu.Entities.Mapping;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DuyurularMap());
            modelBuilder.Configurations.Add(new EmanetKitaplarMap());
            modelBuilder.Configurations.Add(new HakkimizdaMap());
            modelBuilder.Configurations.Add(new İletisimMap());
            modelBuilder.Configurations.Add(new KitapHareketleriMap());           
            modelBuilder.Configurations.Add(new KitapKayitHareketleriMap());
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new KitapTurleriMap());
            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new KullaniciRolleriMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new UyelerMap());
        }
    }
}
