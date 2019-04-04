using Lumper.Data;
using Lumper.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumper.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public string ApplicationId { get; set; }
        public string User { get; set; }

        public ApplicationUser UserId { get; set; }
        public Application Application { get; set; }
    }
}
