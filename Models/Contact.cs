using Categories.Models;
using Subcategories.Models;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact
    {
        public int id { get; set; }
        [Required]
        [MinLength(3)]
        public string name { get; set; }
        [Required]
        [MinLength(3)]
        public string lastname { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        public string password { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string subcategory { get; set; }
        [Required]
        [Phone]
        public string phone { get; set; }
        [Required]
        public string birthdate { get; set; }
        public Contact()
        {

        }
    }
}
