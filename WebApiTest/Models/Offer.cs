using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTest.Converters;

namespace WebApiTest.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PropertyType PropertyType { get; set; }
        [JsonConverter(typeof(RealEstateDetailsConverter))]
        public IRealEstateDetails RealEstateDetails { get; set; }
    }
}
