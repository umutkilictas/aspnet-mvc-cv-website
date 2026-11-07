using System.Web.Mvc;
using Cv_MVC.Models.Entity;
using Cv_MVC.Repositories;

namespace Cv_MVC.Controllers
{
    public class DeneyimController : Controller
    {
        private readonly DeneyimRepository repo = new DeneyimRepository();

        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult deneyimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult deneyimEkle(Table_Deneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult deneyimSil(int id)
        {
            Table_Deneyimlerim t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult deneyimGetir(int id)
        {
            Table_Deneyimlerim t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult deneyimGetir(Table_Deneyimlerim p)
        {
            Table_Deneyimlerim t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Tarih = p.Tarih;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}