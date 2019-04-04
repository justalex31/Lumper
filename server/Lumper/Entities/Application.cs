using Lumper.Entities.Base;
using Lumper.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lumper.Entities
{
    public class Application : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime StartAt { get; set; }
        public Status Status { get; set; }
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Comment> Comments { get; set; }

        /// <summary>
        /// сахар бизнес логики (требуется уточнение)
        /// </summary>
        [NotMapped]
        public DateTime EndAt { get; set; }

        /// <summary>
        /// сахар бизнес логики (требуется уточнение)
        /// </summary>
        [NotMapped]
        public string Requirements { get; set; }

        public Application() => Comments = new HashSet<Comment>();
    }
}
