﻿using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Mapping
{
    public class KullaniciHareketleriMap:EntityTypeConfiguration<KullaniciHareketleri>
    {
        public KullaniciHareketleriMap()
        {
            this.ToTable("KullaniciHareketleri");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artan Sayı
            this.Property(x => x.Aciklama).HasMaxLength(4000);
            this.HasRequired(x => x.Kullanicilars).WithMany(x => x.kullaniciHareketleri).HasForeignKey(x => x.KullaniciId);
        }
    }
}
