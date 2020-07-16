using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Models
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public Address[] DeliveryAddress { get; set; }

        public string PaymentInformatio { get; set; }

        public int[] SavedProviders { get; set; }
    }
}
