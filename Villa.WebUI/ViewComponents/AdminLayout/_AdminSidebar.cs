using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayout
{
    public class _AdminSidebar: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
