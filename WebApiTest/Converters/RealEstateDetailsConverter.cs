using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using WebApiTest.Models;

namespace WebApiTest.Converters
{
    public class RealEstateDetailsConverter<T> : CustomCreationConverter<IRealEstateDetails> where T: IRealEstateDetails, new() 
    {
        public override IRealEstateDetails Create(Type objectType)
        {
            return new T();
        }
    }
}
