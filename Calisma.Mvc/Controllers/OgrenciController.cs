using Calisma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calisma.Mvc.Controllers
{
    public class OgrenciController : Controller
    {
        CalismaContext calismaContext = new CalismaContext();
        // GET: Ogrenci
        public ActionResult Index()
        {
            List<Ogrenci> data = calismaContext.Ogrenci.ToList();
            return View(data);
        }

        [ActionName("Ekle")]
        public ActionResult Ekle_get()
        {
            return View();
        }

        [HttpPost, ActionName("Ekle")]
        public ActionResult Ekle_post(Ogrenci ogrenci)
        {
            calismaContext.Ogrenci.Add(ogrenci);
            calismaContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detay(int id)
        {
            var ogrenci = calismaContext.Ogrenci.Find(id);
            //var ogrenci2 = calismaContext.Ogrenci.Where(o => o.Id == id).FirstOrDefault();
            return View(ogrenci);
        }
    }
}