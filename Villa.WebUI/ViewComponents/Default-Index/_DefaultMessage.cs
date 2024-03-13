using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
