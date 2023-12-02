using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
