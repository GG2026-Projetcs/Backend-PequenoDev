using Microsoft.AspNetCore.Mvc;

namespace PequenoDevAPI.Controllers
{
    public class ModuloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
