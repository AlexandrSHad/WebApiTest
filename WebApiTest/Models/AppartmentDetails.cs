using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class AppartmentDetails : IRealEstateDetails
    {
        public int Id { get; set; }
        public int RoomsCount { get; set; }
        public bool Balcony { get; set; }
    }
}
