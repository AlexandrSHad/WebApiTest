using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApiTest.Models;

namespace WebApiTest.Converters
{
    public class RealEstateDetailsConverter : JsonCreationConverter<IRealEstateDetails>
    {
        public override IRealEstateDetails Create(Type objectType, JObject jObject)
        {
            return new AppartmentDetails { RoomsCount = 100 };
        }
    }
}
