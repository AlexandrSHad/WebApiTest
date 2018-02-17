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

            if (propertyType == PropertyType.Appartment)
            {
                serializer.Converters.Insert(0, new RealEstateDetailsConverter<AppartmentDetails>());
            }
            else if (propertyType == PropertyType.Garage)
            {
                serializer.Converters.Insert(0, new RealEstateDetailsConverter<GarageDetails>());
            }
            else
            {
                throw new ArgumentException("Unknown property type.");
            }

            var obj = new Offer();
            serializer.Populate(jObject.CreateReader(), obj);

            return obj;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }
    }
}
