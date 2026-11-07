using System.Web.Mvc;
using Cv_MVC.Models.Entity;
using Cv_MVC.Repositories;

namespace Cv_MVC.Controllers
{
    public class IletisimController : Controller
    {
        private readonly GenericRepository<Table_Iletisim> repo = new GenericRepository<Table_Iletisim>();

        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}