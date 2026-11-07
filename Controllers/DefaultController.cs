using System;
using System.Linq;
using System.Web.Mvc;
using Cv_MVC.Models.Entity;

namespace Cv_MVC.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly CvDbEntities db = new CvDbEntities();

        public ActionResult Index()
        {
            var degerler = db.Table_Hakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.Table_SosyalMedya.Where(x => x.Durum == true).ToList();
            return PartialView(sosyalMedya);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Table_Deneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitimler = db.Table_Egitimlerim.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.Table_Yeteneklerim.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.Table_Hobilerim.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalarim()
        {
            var sertifikalar = db.Table_Sertifikalarim.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Iletisim(Table_Iletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Table_Iletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}