using Mvc_Kutuphane_Otomasyonu.Entities.DAL;
using Mvc_Kutuphane_Otomasyonu.Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Kutuphane_Otomasyonu.Controllers
{
    public class KitapTurleriController : Controller
    {
        KutuphaneContext context = new KutuphaneContext();
        KitapTurleriDAL kitapTurleriDAL = new KitapTurleriDAL();
        // GET: KitapTurleri
        public ActionResult Index()
        {
            var model = kitapTurleriDAL.GetAll(context);
            return View(model);
        }
    }
}