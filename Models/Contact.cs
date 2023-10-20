namespace Contacts.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public string phone { get; set; }
        public string birthdate { get; set; }
        public Contact()
        {

        }
    }
}
