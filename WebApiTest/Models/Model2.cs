using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Model2 : IModel
    {
        public int Id { get; set; }
        public ModelTypes ModelType { get; set; }
        public string Property2 { get; set; }
    }
}
