using Microsoft.AspNetCore.Mvc;

namespace Amado.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class Basecontroller : Controller 
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
