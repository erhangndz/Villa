using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
