using Fruitkha.Data;
using Fruitkha.Models;
using Fruitkha.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
    public class ShopController : Controller
    {
		public IActionResult Index()
        {

			var viewModel = new ShopIndexVM
			{
				Products = ProductRepository.GetProducts()
			};
			return View(viewModel);
		}


		public IActionResult SingleProduct()
		{
			return View();
		}
	}
}
