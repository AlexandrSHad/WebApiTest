using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTest.Models;

namespace WebApiTest.Converters
{
    public class ModelApiConverter : CustomCreationConverter<IModel>
    {
        public override IModel Create(Type objectType)
        {
            return new Model1();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            JObject jObject = JObject.Load(reader);

            //IModel obj = Create(objectType);

            int modelType = jObject.Value<int>("modelType");

            IModel obj;

            switch (modelType)
            {
                case 1:
                    //objectType = typeof(Model1);
                    obj = new Model1();
                    break;
                case 2:
                    //objectType = typeof(Model2);
                    obj = new Model2();
                    break;
                default:
                    obj = new Model1();
                    break;
            }
            
            serializer.Populate(jObject.CreateReader(), obj);
            return obj;
        }
    }
}
