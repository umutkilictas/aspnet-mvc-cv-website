using System.Web.Mvc;
using Cv_MVC.Models.Entity;
using Cv_MVC.Repositories;

namespace Cv_MVC.Controllers
{
    public class HobiController : Controller
    {
        private readonly GenericRepository<Table_Hobilerim> repo = new GenericRepository<Table_Hobilerim>();

        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }

        [HttpPost]
        public ActionResult Index(Table_Hobilerim p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}