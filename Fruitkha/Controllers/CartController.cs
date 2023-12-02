using Fruitkha.Data;
using Fruitkha.Models;
using Fruitkha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json;

namespace Fruitkha.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index(int id)
		{
			List<Basket> BasketItemLists;

			return View();
		}
	}
}
