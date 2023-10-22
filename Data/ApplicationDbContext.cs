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
			DataSeeder.Seed(this);
        }
        public DbSet<Contacts.Models.Contact>? Contact { get; set; }
        public DbSet<Categories.Models.Category>? Category { get; set; }
        public DbSet<Subcategories.Models.Subcategory>? Subcategory { get; set; }
    }
}