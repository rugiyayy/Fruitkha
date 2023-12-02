using Fruitkha.Data;
using Fruitkha.Models;
using Fruitkha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fruitkha.Controllers
{
    public class NewsController : Controller
    {
        List<News> _news;

        public NewsController()
        {
			_news = NewsRepository.GetNews();
        }
        public IActionResult Index()
        {
            NewsIndexVM model = new()
            {
                News = _news
            };
            return View(model);
        }

		public IActionResult SingleNews(int Id)
		{
			var singleNews=NewsRepository.GetNews().FirstOrDefault(x => x.Id == Id);
            //if(singleNews is null) return RedirectToAction("Index", "Error");

            var model = new NewsSingleNewsVM
            {
                News = singleNews
            };
			return View(model);
		}


	}
}

