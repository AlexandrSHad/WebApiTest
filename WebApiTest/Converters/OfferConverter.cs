using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApiTest.Models;

namespace WebApiTest.Converters
{
    public class OfferConverter : JsonConverter
    {
        public override bool CanWrite { get; } = false;
        public override bool CanRead { get; } = true;

        public override bool CanConvert(Type objectType)
        {
            return typeof(Offer).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            JObject jObject = JObject.Load(reader);

            PropertyType propertyType = (PropertyType)jObject.Value<int>("propertyType");

            var obj = new Offer();
            serializer.Populate(jObject.CreateReader(), obj);

            IRealEstateDetails details;
            if (propertyType == PropertyType.Appartment)
            {
                details = new AppartmentDetails();
            }
            else if (propertyType == PropertyType.Garage)
            {
                details = new GarageDetails();
            }
            else
            {
                throw new ArgumentException("Unknown property type.");
            }

            serializer.Populate(jObject["realEstateDetails"].CreateReader(), details);

            obj.RealEstateDetails = details;

            return obj;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }
    }
}
