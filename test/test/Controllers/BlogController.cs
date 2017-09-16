using System.Web.Mvc;

namespace test.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}