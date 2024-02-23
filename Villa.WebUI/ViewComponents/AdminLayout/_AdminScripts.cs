using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayout
{
    public class _AdminScripts: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
