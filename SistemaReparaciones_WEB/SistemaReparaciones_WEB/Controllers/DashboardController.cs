using Microsoft.AspNetCore.Mvc;

namespace SistemaReparaciones_WEB.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Repuestos()
        {
            return View();
        }
    }
}
