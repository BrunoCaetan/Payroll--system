﻿using Microsoft.AspNetCore.Mvc;
using Payroll_system.Models;
using Payroll_system.Repositorio;
using System.Diagnostics;

namespace Payroll_system.Controllers
{
    public class HomeController : Controller

    {
   
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Empresa( )
        {

            return View();
        }
        public IActionResult Funcionario()
        {
            return View();
        }
        public IActionResult Ferias()
        {
            return View();
        }
        public IActionResult Licenca()
        {
            return View();
        }
        public IActionResult Holerite()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}