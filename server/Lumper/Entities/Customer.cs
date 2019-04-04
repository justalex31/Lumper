using Lumper.Data;

namespace Lumper.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public ApplicationUser Identity { get; set; }
    }
}
