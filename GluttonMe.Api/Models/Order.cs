using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ProviderId { get; set; }

        public int UserId { get; set; }

        public Menu[] ItemsOrdered { get; set; }

        public Address DeliveryAddress { get; set; }

        public DateTime OrderedOn { get; set; }


    }
}
