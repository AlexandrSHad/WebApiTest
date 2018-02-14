using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PropertyType PropertyType { get; set; }
        public IRealEstateDetails RealEstateDetails { get; set; }
    }
}
