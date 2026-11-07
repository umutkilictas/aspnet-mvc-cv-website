using System.Web.Mvc;
using Cv_MVC.Models.Entity;
using Cv_MVC.Repositories;

namespace Cv_MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly GenericRepository<Table_Admin> repo = new GenericRepository<Table_Admin>();

        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }

        [HttpGet]
        public ActionResult adminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult adminEkle(Table_Admin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult adminSil(int id)
        {
            Table_Admin t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult adminGuncelle(int id)
        {
            Table_Admin t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult adminGuncelle(Table_Admin p)
        {
            Table_Admin t = repo.Find(x => x.ID == p.ID);
            t.KullaniciAdi = p.KullaniciAdi;
            t.Sifre = p.Sifre;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}