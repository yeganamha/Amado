using Microsoft.AspNetCore.Mvc;

namespace Amado.Areas.Admin.Controllers
{
    public class HomeController : Basecontroller
    {
        public new IActionResult Index()
        {
            return View();
        }
    }
}
