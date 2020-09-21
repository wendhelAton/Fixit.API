using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fix.API.Infrastructure.Domain.Models
{
    public class BaseModel
    {
        public Guid? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public BaseModel()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
