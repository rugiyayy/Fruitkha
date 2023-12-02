using Fruitkha.Models;
using System;
namespace Fruitkha.Data
{
	public class ProductRepository
	{
		public static List<Product> GetProducts()
		{
			return new()
			{
				new Product
				{
					Id = 1,
					Name = "Strawberry",
					Price = 1,
					ImagePath="product-img-1.jpg",
				},

				new Product
				{
					Id = 2,
					Name = "Berry",
					Price = 1,
					ImagePath="product-img-2.jpg",
				},

				new Product
				{
					Id = 3,
					Name = "Lemon",
					Price = 1,
					ImagePath="product-img-3.jpg",
				},
				new Product
				{
					Id = 4,
					Name = "Apple",
					Price = 1,
					ImagePath="product-img-4.jpg",
				},

				new Product
				{
					Id =5,
					Name = "Grape",
					Price = 1,
					ImagePath="product-img-5.jpg",
				},

				new Product
				{
					Id = 6,
					Name = "Kiwi",
					Price = 1,
					ImagePath="product-img-6.jpg",
				}

			};

		}
	}
}
