using Fruitkha.Data;
using Fruitkha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fruitkha.Controllers
{
    public class StaticHomeController : Controller
    {
        
        public IActionResult Index()
        {

            var viewModel = new StaticHomeIndexVM
            {
                Products = ProductRepository.GetProducts().Take(3).ToList(),
                Testimonials=TestimonialRepository.GetTestimonials()
			};
            return View(viewModel);


		}



		//public IActionResult Error()
		//{
		//	return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		//}

	}
}