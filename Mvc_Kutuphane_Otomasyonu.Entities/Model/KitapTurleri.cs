using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model
{
    [Table("KitapTurleri")]
    public class KitapTurleri
    {
        public  int Id { get; set; }
        [StringLength(50)]
        public string KitapTuru { get; set; }
        public string Aciklama { get; set; }
    }
}
