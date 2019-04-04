using Lumper.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumper.Entities
{
    public class UserRating : BaseEntity
    {
        public decimal Value { get; set; }
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
