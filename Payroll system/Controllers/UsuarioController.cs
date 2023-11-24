using Microsoft.AspNetCore.Mvc;

namespace Payroll_system.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
