using System.Web.Mvc;
using Cv_MVC.Models.Entity;
using Cv_MVC.Repositories;

namespace Cv_MVC.Controllers
{
    public class EgitimController : Controller
    {
        private readonly GenericRepository<Table_Egitimlerim> repo = new GenericRepository<Table_Egitimlerim>();

        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        [HttpGet]
        public ActionResult egitimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult egitimEkle(Table_Egitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("egitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult egitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult egitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }

        [HttpPost]
        public ActionResult egitimDuzenle(Table_Egitimlerim t)
        {
            if (!ModelState.IsValid)
            {
                return View("egitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == t.ID);
            egitim.Baslik = t.Baslik;
            egitim.AltBaslik1 = t.AltBaslik1;
            egitim.AltBaslik2 = t.AltBaslik2;
            egitim.Tarih = t.Tarih;
            egitim.GNO = t.GNO;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult egitimGetir(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View("egitimDuzenle", egitim);
        }

        [HttpPost]
        public ActionResult egitimGetir(Table_Egitimlerim t)
        {
            return egitimDuzenle(t);
        }
    }
}