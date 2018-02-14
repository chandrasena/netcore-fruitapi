using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fruit_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fruit_api.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        private readonly IFruitService _fruitService;

        public FruitController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }
        // GET api/values
        [HttpGet]
        [Authorize]
        public IEnumerable<Fruit> GetAll()
        {
            var result = _fruitService.GetFruits(); //_context.FruitItems.ToList();
            Console.WriteLine(result);
            return result;
        }
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
