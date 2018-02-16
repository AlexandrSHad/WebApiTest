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
    public class ModelApiConverter : JsonCreationConverter<IModel>
    {
        private readonly Dictionary<ModelTypes, Type> _typesDictionary = new Dictionary<ModelTypes, Type> {
            { ModelTypes.First,  typeof(Model1) },
            { ModelTypes.Second, typeof(Model2) }
        };

        public override IModel Create(Type objectType, JObject jObject)
        {
            ModelTypes modelType = (ModelTypes)jObject.Value<int>("modelType");

            return (IModel)jObject.ToObject(_typesDictionary[modelType]);
        }
    }
}
