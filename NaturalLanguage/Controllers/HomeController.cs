using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NaturalLanguage.BusinessLogic;
using NaturalLanguage.Models;

namespace NaturalLanguage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculatorBl _calculator;

        public HomeController(ILogger<HomeController> logger, ICalculatorBl calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CalculatorViewModel model)
        {
            ViewBag.Message = "Answer: " + _calculator.Calculate(model.Expression);
            return View(model);
        }
    }
}
