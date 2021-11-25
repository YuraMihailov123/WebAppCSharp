using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using WebApp.Services;
using Newtonsoft.Json.Linq;

namespace WebApp.Controllers
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

        [Route("home/palindrom/{word}")]
        public string Palindrom(string word)
        {
            return Algorithms.IsPalindrom(word);
        }

        [HttpGet]
        [Route("home/sum")]
        public string Sum([FromQuery]int[] arr)
        {
            return "Сумма каждого 2-ого нечетного числа - " + Algorithms.CountSum(arr);
            //return Algorithms.CountSum(someValues);
        }

        [Route("home/linked/sum/{num1}+{num2}")]
        public string SumWithLinkedList(int num1,int num2)
        {
            //335 + 4378
            return Algorithms.LinkedSum(num1, num2);
        }

        public IActionResult Privacy()
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
