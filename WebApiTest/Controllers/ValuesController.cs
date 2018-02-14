using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //public ValuesController(IModel model)
        //{
        //}
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };

            var model = new Model1
            {
                Id = 1,
                Property1 = "Prop 1"
            };

            return Ok(model);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] IModel model)
        {
        }

        [HttpPost("offer")]
        public void PostOffer([FromBody] Offer model)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
