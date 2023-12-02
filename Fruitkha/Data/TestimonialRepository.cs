using Fruitkha.Models;
using System;
namespace Fruitkha.Data
{
	public class TestimonialRepository
	{
		public static List<Testimonial> GetTestimonials()
		{
			return new()
			{
				new Testimonial
				{
					Id = 1,
					FullName = "Adam jjaskdns",
					Position="Local shop owner",
					Details = "Info ofno ofno ofjfojfjfkem",
					ImagePath="avatar3.png",

				},

				new Testimonial
				{
					Id = 2,
					FullName = "Adam jjaskdns",
					Position="Local shop owner",
					Details = "Info ofno ofno ofjfojfjfkem",
					ImagePath="avatar2.png",

				},

				new Testimonial
				{
					Id = 3,
					FullName = "Adam jjaskdns",
					Position="Local shop owner",
					Details = "Info ofno ofno ofjfojfjfkem",
					ImagePath="avatar1.png",
				},
				
				

			};

		}
	}
}
