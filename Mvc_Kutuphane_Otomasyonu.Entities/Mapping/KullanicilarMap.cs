using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Mapping
{
    public class KullanicilarMap:EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap() {
            this.ToTable("Kullanicilar");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artan Sayı
            this.Property(x => x.KullaniciAdi).IsRequired().HasMaxLength(50); 
            this.Property(x => x.Sifre).IsRequired().HasMaxLength(50);
            this.Property(x => x.AdiSoyadi).IsRequired().HasMaxLength(100);
            this.Property(x => x.Email).IsRequired().HasMaxLength(150);
            this.Property(x => x.Telefon).IsRequired().HasMaxLength(200);
            this.Property(x => x.Adres).IsRequired().HasMaxLength(500);

           
        }
    }
}
