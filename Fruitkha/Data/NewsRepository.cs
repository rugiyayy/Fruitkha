using Fruitkha.Models;

namespace Fruitkha.Data
{
	public class NewsRepository
	{
		public static List<News> GetNews()
		{
			return new()
			{
				new News
				{
					Id = 1,
					Title = "11111will vainly look for fruit on it in autumn",
					Description = "info info info info info info",
					ImagePath="news-bg-3.jpg",
				},

				new News
				{
					Id = 2,
					Title = "22222will vainly look for fruit on it in autumn",
					Description = "info info info info info info",

					ImagePath="news-bg-1.jpg",
				},

				new News
				{
					Id = 3,
					Title = "33333will vainly look for fruit on it in autumn",
					Description = "info info info info info info",

					ImagePath="news-bg-2.jpg",
				},
				new News
				{
					Id = 4,
					Title = "444444will vainly look for fruit on it in autumn",
					Description = "info info info info info info",

					ImagePath="news-bg-3.jpg",
				},
				new News
				{
					Id = 5,
					Title = "55555will vainly look for fruit on it in autumn",
					Description = "info info info info info info",

					ImagePath="news-bg-3.jpg",
				},

				new News
				{
					Id = 6,
					Title = "6666666will vainly look for fruit on it in autumn",
					Description = "info info info info info info",

					ImagePath="news-bg-1.jpg",
				}

			};

		}
	}
}
