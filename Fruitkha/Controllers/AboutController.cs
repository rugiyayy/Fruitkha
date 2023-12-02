using Fruitkha.Data;
using Fruitkha.Models;
using Fruitkha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fruitkha.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult Index()
        {

			var viewModel = new AboutIndexVM
			{
				Testimonials = TestimonialRepository.GetTestimonials()
			};
			return View(viewModel);
        }

    }
}