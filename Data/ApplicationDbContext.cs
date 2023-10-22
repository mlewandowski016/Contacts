using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Categories.Models;
using Subcategories.Models;

namespace Contacts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
			
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(
				new { id = 1, category = "business" },
				new { id = 2, category = "private" },
				new { id = 3, category = "other" }
				);

			modelBuilder.Entity<Subcategory>().HasData(
				new { id = 1, subcategory = "boss" },
				new { id = 2, subcategory = "coworker" },
				new { id = 3, subcategory = "client" }
				);
		}
        public DbSet<Contacts.Models.Contact>? Contact { get; set; }
        public DbSet<Categories.Models.Category>? Category { get; set; }
        public DbSet<Subcategories.Models.Subcategory>? Subcategory { get; set; }
    }
}