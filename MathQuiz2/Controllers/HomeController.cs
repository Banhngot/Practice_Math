using MathQuiz2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MathQuiz2.Controllers
{
    public class HomeController : Controller
    {
        YdckmwsnLuyentoanContext db = new YdckmwsnLuyentoanContext();
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstExam = db.Exams.ToList();
            return View(lstExam);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
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