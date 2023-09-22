using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using Mvc_Kutuphane_Otomasyonu.Entities.Model.Context;
using Mvc_Kutuphane_Otomasyonu.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.DAL
{
    public class EmanetKitaplarDAL:GenericRepository<KutuphaneContext, EmanetKitaplar>
    {
    }
}
