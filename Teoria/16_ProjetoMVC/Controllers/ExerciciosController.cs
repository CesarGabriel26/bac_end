using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _16_ProjetoMVC.Controllers
{
    public class ExerciciosController : Controller
    {

        public IActionResult Exercicio1()
        {
            return View();
        }
        public IActionResult Exercicio2()
        {
            return View();
        }

    }
}