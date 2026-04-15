using Microsoft.AspNetCore.Mvc;

namespace PequenoDevAPI.Controllers
{
    public class ExercicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
