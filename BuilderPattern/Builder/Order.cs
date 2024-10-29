using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class Order
    {
        public int Number { get; init; } 
        public DateTime CreatedOn { get; init; }
        public Address ShippingAddress { get; set; }
    }
    public class Address{
        public string Street { get; init; }
        public string City { get; init; }
        public string Zip { get; init; }

        public string State { get; init; }
        public string Country { get; init; }

    }
    
}