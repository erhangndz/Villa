using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLogo:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
