using Microsoft.AspNetCore.Mvc;

namespace PequenoDevAPI.Controllers
{
    public class AtividadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
