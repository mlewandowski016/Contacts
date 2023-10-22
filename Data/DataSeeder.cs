using Categories.Models;
using Subcategories.Models;

namespace Contacts.Data
{
	public class DataSeeder
	{
		public static void Seed(ApplicationDbContext context) 
		{
			if (!context.Category.Any() && !context.Subcategory.Any())
			{
				context.Category.AddRange(
					new Category { category = "business" },
					new Category { category = "private" },
					new Category { category = "other" }
					);
			
				context.Subcategory.AddRange(
				new Subcategory { subcategory = "boss", categoryId = 1},
				new Subcategory { subcategory = "coworker", categoryId = 1 },
				new Subcategory { subcategory = "client", categoryId = 1 }
				);
				context.SaveChanges();
			}
		}
	}
}
