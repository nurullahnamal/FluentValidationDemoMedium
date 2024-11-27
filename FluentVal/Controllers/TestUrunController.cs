using FluentVal.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentVal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestUrunController : ControllerBase
	{
		[HttpPost]
		public IActionResult CreateProduct([FromBody] Product product)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState); // Doğrulama hatalarını döner
			}

			// Ürün oluşturma işlemleri
			return Ok("Ürün Başarılı şekilde Oluşturuldu");
		}
	}
}
