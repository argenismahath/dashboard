using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using WebApplication3.Models;
using WebApplication3.Repositorio;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IrepositorioUser irepositorioUser;

        public HomeController(ILogger<HomeController> logger, IrepositorioUser irepositorioUser )
        {
            _logger = logger;
            this.irepositorioUser = irepositorioUser;
        }

       

        public IActionResult Index()
        {
            

                var Data = new user()
                {
                    Age = 20,
                    Name = "Oleider Gonzalez",
                    Career = "Desarrollador full stack"
                };
            return View(Data);
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


        [HttpGet]
        public IActionResult Userf()
        {
            return View();
        }
    }
}