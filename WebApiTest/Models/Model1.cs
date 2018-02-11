using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Model1 : IModel
    {
        public int Id { get; set; }
        public ModelTypes ModelType { get; set; }
        public string Property1 { get; set; }

        //public Model1()
        //{
        //    Property1 = "Default 1";
        //}
    }
}
