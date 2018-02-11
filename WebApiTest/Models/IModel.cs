using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public interface IModel
    {
        int Id { get; set; }
        ModelTypes ModelType { get; set; }
    }
}
