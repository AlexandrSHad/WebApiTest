using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApiTest.Models;

namespace WebApiTest.Converters
{
    public class OfferConverter : JsonCreationConverter<Offer>
    {
        public override Offer Create(Type objectType, JObject jObject)
        {
            var obj = new Offer();

            PropertyType propertyType = (PropertyType)jObject.Value<int>("propertyType");

            IRealEstateDetails details;

            if (propertyType == PropertyType.Appartment)
            {
                details = jObject["realEstateDetails"].ToObject<AppartmentDetails>();
            }
            else if (propertyType == PropertyType.Garage)
            {
                details = jObject["realEstateDetails"].ToObject<GarageDetails>();
            }
            else
            {
                throw new ArgumentException("Unknowm property type.");
            }

            obj.RealEstateDetails = details;

            //Offer obj = (Offer)jObject.ToObject(typeof(Offer));

            //Offer obj = (Offer)jObject.ToObject(typeof(Offer), serializer);

            //var ser = new JsonSerializer();
            //ser.Converters.Insert(0, new RealEstateDetailsConverter());


            //Offer obj = (Offer)jObject.ToObject(typeof(Offer), ser);

            //if (propertyType == PropertyType.Appartment)
            //{
            //    details = jObject["details"].ToObject<AppartmentDetails>();
            //}
            //else// if (propertyType == PropertyType.Garage)
            //{
            //    details = jObject["details"].ToObject<GarageDetails>();
            //}

            //if (details != null)
            //{
            //    obj.RealEstateDetails = details;
            //}

            return obj;
        }
    }
}
