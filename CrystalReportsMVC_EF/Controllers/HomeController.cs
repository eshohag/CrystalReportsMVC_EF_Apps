using CrystalReportsMVC_EF.Models;
using System.Linq;
using System.Web.Mvc;

namespace CrystalReportsMVC_EF.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext anApplicationDbContext = new ApplicationDbContext();
        public ActionResult Index()
        {
            var products = anApplicationDbContext.Products.ToList();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}