using Microsoft.AspNetCore.Mvc;

namespace PequenoDevAPI.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
