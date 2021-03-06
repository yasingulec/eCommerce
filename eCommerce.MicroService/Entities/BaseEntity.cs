using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Entities
{
    //base abstract domain object
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime? Modified_At { get; set; } = null;
    }
}
