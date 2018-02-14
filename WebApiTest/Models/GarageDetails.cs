using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class GarageDetails : IRealEstateDetails
    {
        public int Id { get; set; }
        public string TypeOfGarage { get; set; }
    }
}
