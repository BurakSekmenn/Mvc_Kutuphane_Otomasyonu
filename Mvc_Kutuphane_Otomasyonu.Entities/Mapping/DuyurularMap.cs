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
    public class DuyurularMap: EntityTypeConfiguration<Duyrular>
    {
        private DatabaseGeneratedOption? databaseGeneratedOption;

        public DuyurularMap()
        {
            this.ToTable("Duyrular");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artan Sayı
            this.Property(x => x.Baslik).HasColumnType("varchar");//Kolon Türü Belirlendi
            this.Property(x => x.Baslik).IsRequired().HasMaxLength(150);// MAx ve zorunlu alan sayısı yapıldı
            this.Property(x => x.Duyuru).IsRequired().HasMaxLength(500);
            this.Property(x => x.Acıklama).HasMaxLength(5000);
            this.Property(x => x.Id).HasColumnName("Id"); // Kolon Adlandırma
            this.Property(x => x.Baslik).HasColumnName("Baslik");// Kolon Adlandırma
            this.Property(x => x.Duyuru).HasColumnName("Duyuru");// Kolon Adlandırma
            this.Property(x => x.Acıklama).HasColumnName("Aciklama");// Kolon Adlandırma
            this.Property(x => x.Tarih).HasColumnName("Tarih");// Kolon Adlandırma
        }
    }
}
