using System.Diagnostics;
using Fv.Entity;
using Fv.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fv.Controllers
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

		[HttpPost]
		public IActionResult CreateProduct([FromBody] Person person)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState); // Doğrulama hatalarını döner
			}

			// Ürün oluşturma işlemleri
			return Ok("Person created successfully!");
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
