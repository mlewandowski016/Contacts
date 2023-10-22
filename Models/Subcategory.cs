using Categories.Models;

namespace Subcategories.Models
{
    public class Subcategory
    {
        public int id { get; set; }
        public string subcategory { get; set; }
        public int categoryId { get; set; }
        public Subcategory()
        {

        }
    }
}
