using SmallCSharpApp.Models;
using System.Web.Mvc;

namespace SmallCSharpApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new InputViewModel());
        }

        public ActionResult Calculate(int a, int b)
        {
            return View();
        }
    }
}