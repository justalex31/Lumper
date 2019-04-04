using Lumper.Data;
using Lumper.Entities.Base;

namespace Lumper.Entities
{
    public class Customer : BaseEntity
    {
        public string IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public ApplicationUser Identity { get; set; }
    }
}
