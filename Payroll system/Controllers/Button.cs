using Microsoft.AspNetCore.Mvc;
using Payroll_system.Models;
using System.Diagnostics;

namespace Payroll_system.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult EmpresaEditar()
        { 
            return View(); 
        }

        public IActionResult FeriasEditar()
        {
            return View();
        }

        public IActionResult FuncionarioCadastrar()
        {
            return View();
        }

        public IActionResult FuncionarioEditar()
        {
            return View();
        }

        public IActionResult FuncionarioExcluir()
        {
            return View();
        }

        public IActionResult LicencaEditar()
        {
            return View();
        }

        public IActionResult HoleriteGerado()
        {
            return View();
        }
    }
}
