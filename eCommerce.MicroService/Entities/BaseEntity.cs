using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }
    }
}
